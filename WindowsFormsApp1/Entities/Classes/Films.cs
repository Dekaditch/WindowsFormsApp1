using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities.Interfaces;

namespace WindowsFormsApp1.Entities
{
    public class Films : IFilms
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public string ScriptWriter { get; private set; }
        public string StageDirector { get; private set; }
        public string Producer { get; private set; }//company
        public int ReleaseYear { get; private set; }
        public double FilmCost { get; private set; }

        public Films(string title, string genre, string scriptWriter, string stageDirector, string producer, int releaseYear, double filmCost) 
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(nameof(title), "Название фильма не может быть пустой");
            if (string.IsNullOrWhiteSpace(genre)) throw new ArgumentException(nameof(genre), "Жанр фильма не может быть пустым");
            if (string.IsNullOrWhiteSpace(scriptWriter)) throw new ArgumentException(nameof(scriptWriter), "Автор сценария фильма не может быть пустым");
            if (string.IsNullOrWhiteSpace(stageDirector)) throw new ArgumentException(nameof(stageDirector), "Директор фильма не может быть пустым");
            if (string.IsNullOrWhiteSpace(producer)) throw new ArgumentException(nameof(producer), "Компания поставщик фильма не может быть пустой");
            if (releaseYear <= 1887 && releaseYear>DateTime.Today.Year) throw new ArgumentException(nameof(releaseYear), "Год выпуска фильма не должен быть меньше 1887 и больше текущего года");
            if (filmCost <= 0) throw new ArgumentException(nameof(filmCost), "Стоимость фильма должна иметь положительное значение");
            Title = title;
            Genre = genre;
            ScriptWriter = scriptWriter;
            StageDirector = stageDirector;
            Producer = producer;
            ReleaseYear = releaseYear;
            FilmCost = filmCost;
        }


        public void Update(string title, string genre, string scriptWriter, string stageDirector, string producer, int releaseYear, double filmCost)
        { 
            Title = title; 
            Genre = genre;
            ScriptWriter = scriptWriter;
            StageDirector = stageDirector;
            Producer = producer;
            ReleaseYear = releaseYear;
            FilmCost = filmCost;
        }
           
    }
}
