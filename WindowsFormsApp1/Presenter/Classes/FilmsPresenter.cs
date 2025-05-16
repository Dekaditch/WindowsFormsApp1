using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenter.Classes
{
    internal class FilmsPresenter : IFilmsPresenter
    {
        private readonly IFilmsService _filmsService;
        public FilmsPresenter(IFilmsService filmsService)
        {
            _filmsService = filmsService;
        }
        public void AddFilm(FilmsDTO filmsDTO)
        {
            _filmsService.AddFilms (filmsDTO);
        }
        public void RemoveFilm(string title)
        {
            _filmsService.RemoveFilms (title);
        }
        public void UpdateFilm(FilmsDTO filmsDTO) 
        {
            var film = FilmsMap.ToEntity (filmsDTO);
            _filmsService.UpdateFilms (film);
        }
        public List<FilmsDTO> GetAllFilms()
        {
            return _filmsService.GetAllFilms();
        }
    }
}
