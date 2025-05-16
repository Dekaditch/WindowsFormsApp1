using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Presenter.Classes;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Forms
{
    public partial class CinemaForm : Form, ICinemaView
    {
        public CinemaForm(ICinemaPresenter cinemaPresenter)
        {
            InitializeComponent();
            button_Update.Enabled = false;
            _cinemaPresenter = cinemaPresenter;
            LoadCinemas();
        }
        private int SeatsToInt;
        private readonly ICinemaPresenter _cinemaPresenter;
        private readonly ICinemaService _cinemaService;
        private const string jsonFilePath = "cinemas.json";
        private void LoadCinemas()
        {
            var cinemas = _cinemaPresenter.GetAllCinema();
            dataGridView1.Rows.Clear();
            foreach (var cinema in cinemas)
            {
                AddCinemaToList(cinema);
            }
        }
        public string Address { get => textAddress.Text; set => textAddress.Text = value; }

        public string PhoneNumber { get => textPhone.Text; set => textPhone.Text = value; }

        public string Director { get => textDirector.Text; set => textDirector.Text = value; }

        public string Bank { get => textBank.Text; set => textBank.Text = value; }

        public string BankNumber { get => textBankNumber.Text; set => textBankNumber.Text = value; }

        public string ITN { get => textBank.Text; set => textBank.Text = value; }

        public int Seats { get => SeatsToInt; set => SeatsToInt = value; }

        public string Owner { get => textOwner.Text; set => textOwner.Text = value; }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ClearFields()
        {
            textAddress.Clear();
            textPhone.Clear();
            textDirector.Clear();
            textBank.Clear();
            textBankNumber.Clear();
            textSeats.Clear();
            textOwner.Clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var cinemaDTO = new CinemaDTO
            {
                Address = Address,
                PhoneNumber = PhoneNumber,
                Director = Director,
                Bank = Bank,
                BankNumber = BankNumber,
                ITN = ITN,
                Owner = Owner,
                Seats = Seats
            };
            _cinemaPresenter.AddCinema(cinemaDTO);
            ClearFields();
            SaveCinemaToJson();
        }
        private void SaveCinemaToJson()
        {
            var cinemas = _cinemaPresenter.GetAllCinema();
            var json = JsonConvert.SerializeObject(cinemas, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            ShowMessage("Данные сохранены");
        }

        public void AddCinemaToList(CinemaDTO cinema)
        {
            dataGridView1.Rows.Add(cinema.Address, cinema.PhoneNumber, cinema.Bank,
                cinema.BankNumber, cinema.ITN, cinema.Owner, cinema.Seats);

        }


        public void ClearCinemaList()
        {
            _cinemaPresenter.RemoveCinema(Name);
            ClearFields();
            SaveCinemaToJson();
        }

        private void textSeats_TextChanged(object sender, EventArgs e)
        {
            SeatsToInt = Convert.ToInt32(textSeats.Text);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var objectEntity = _cinemaService.GetCinemaByAddress(textAddress.Text);
            if (objectEntity == null)
            {
                ShowMessage("Кинотеатр с таким адрессом не найден.");
                return;
            }
            var cinemaDTO = new CinemaDTO
            {
                Address = Address,
                PhoneNumber = PhoneNumber,
                Director = Director,
                Bank = Bank,
                BankNumber = BankNumber,
                ITN = ITN,
                Owner = Owner,
                Seats = Seats
            };
            _cinemaPresenter.UpdateCinema(cinemaDTO);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ClearCinemaList();
        }
    }
}
