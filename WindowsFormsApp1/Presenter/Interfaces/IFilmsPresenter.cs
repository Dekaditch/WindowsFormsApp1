using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Presenter.Interfaces
{
    internal interface IFilmsPresenter
    {
        void LoadFilms();
        void AddFilm(FilmsDTO filmsDTO);
        void RemoveFilm(string title);
        void UpdateFilm(FilmsDTO filmsDTO);
        List<FilmsDTO> GetAllFilms();
    }
}
