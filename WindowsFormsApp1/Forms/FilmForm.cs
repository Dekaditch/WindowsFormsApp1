using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Presenter.Classes;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Services.Classes;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Forms
{
    public partial class FilmForm : Form, IFilmsView
    {
        public FilmForm(IFilmsPresenter filmsPresenter)
        {
            InitializeComponent();
            button_Update.Enabled = false;
            _filmPresenter = filmsPresenter;
            LoadFilms();
        }
        private int ReleaseYearToInt
        {
            get 
            {
                return Convert.ToInt32(textReleaseYear.Text);
            }
            set
            {
                textReleaseYear.Text = value.ToString();
            }
        }
        
        private double FilmCostToDouble 
        {
            get
            {
                return Convert.ToDouble(textCost.Text);
            }
            set 
            {
                textCost.Text = value.ToString();
            }
        }
        private readonly IFilmsPresenter _filmPresenter;
        private readonly FilmsService _filmService;
        private const string jsonFilePath = "films.json";
        public void LoadFilms()
        {
            var films = _filmPresenter.GetAllFilms();
            dataGridView1.Rows.Clear();
            foreach (var film in films)
            {
                AddFilmsToList(film);
            }
        }
        public string Title { get => textName.Text; set => textName.Text = value; }
        public string Genre { get => textGenre.Text; set => textGenre.Text = value; }
        public string ScriptWriter { get => textScriptWriter.Text; set => textScriptWriter.Text = value; }
        public string StageDirector { get => textStageDirector.Text; set => textStageDirector.Text = value; }
        public string Producer { get => textProducer.Text; set => textProducer.Text = value; }
        public int ReleaseYear { get => ReleaseYearToInt; set => ReleaseYearToInt = value; }
        public double FilmCost { get => FilmCostToDouble; set => FilmCostToDouble = value; }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearFields()
        {
            textName.Clear();
            textGenre.Clear();
            textScriptWriter.Clear();
            textStageDirector.Clear();
            textProducer.Clear();
            textReleaseYear.Clear();
            textCost.Clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var filmDTO = new FilmsDTO
            {
                Title = Title,
                Genre = Genre,
                ScriptWriter = ScriptWriter,
                StageDirector = StageDirector,
                Producer = Producer,
                ReleaseYear = ReleaseYear,
                FilmCost = FilmCost
            };
            _filmPresenter.AddFilm(filmDTO);
            ClearFields();
            LoadFilms();
            SaveFilmToJson();
        }
        private void SaveFilmToJson()
        {
            var films = _filmPresenter.GetAllFilms();
            var json = JsonConvert.SerializeObject(films, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            ShowMessage("Данные сохранены");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ClearFilmsList();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var objectEntity = _filmService.GetFilmsByTitle(textName.Text);
            if (objectEntity == null)
            {
                ShowMessage("Фильм с данным названием не был найден.");
                return;
            }
            var filmDTO = new FilmsDTO
            {
                Title = Title,
                Genre = Genre,
                ScriptWriter = ScriptWriter,
                StageDirector = StageDirector,
                Producer = Producer,
                ReleaseYear = ReleaseYear,
                FilmCost = FilmCost
            };
            _filmPresenter.UpdateFilm(filmDTO);
        }

        public void ClearFilmsList()
        {
            _filmPresenter.RemoveFilm(Name);
            ClearFields();
            SaveFilmToJson();
        }

        public void AddFilmsToList(FilmsDTO filmsDTO)
        {
            dataGridView1.Rows.Add(filmsDTO.Title, filmsDTO.Genre, filmsDTO.ScriptWriter, filmsDTO.StageDirector,
               filmsDTO.Producer, filmsDTO.ReleaseYear, filmsDTO.FilmCost.ToString());
        }
    }
}
