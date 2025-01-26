using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    internal interface IFilmsView
    {
        string Title { get; }
        string Genre { get; }
        string ScriptWriter { get; }
        string StageDirector { get; }
        string Producer { get; }
        int ReleaseYear { get; }
        double FilmCost { get; }
        void ShowMessage(string message);
        void ClearFields();
        void ClearFilmsList();
        void AddFilmsToList(FilmsDTO filmsDTO);
    }
}
