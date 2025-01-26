using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenter.Classes
{
    internal class FilmsPresenter
    {
        private readonly IFilmsService _filmsService;
        private readonly IFilmsView _filmsView;
        public FilmsPresenter(IFilmsService filmsService, IFilmsView filmsView)
        {
            _filmsService = filmsService;
            _filmsView = filmsView;
        }
        public void LoadFilms() 
        {
            var films = _filmsService.GetAllFilms();
            _filmsView.ClearFilmsList();
            foreach (var film in films)
            {
                _filmsView.AddFilmsToList(film);
            }
        }
        public void AddFilm(FilmsDTO filmsDTO)
        {
            _filmsService.AddFilms (filmsDTO);
            LoadFilms();
        }
        public void RemoveFilm(string title)
        {
            _filmsService.RemoveFilms (title);
            LoadFilms();
        }
        public void UpdateFilm(FilmsDTO filmsDTO) 
        {
            var film = FilmsMap.ToEntity (filmsDTO);
            _filmsService.UpdateFilms (film);
            LoadFilms();
        }
        public List<FilmsDTO> GetAllFilms()
        {
            return _filmsService.GetAllFilms();
        }
    }
}
