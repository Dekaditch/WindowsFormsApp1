using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Interfaces;

namespace WindowsFormsApp1.Services.Classes
{
    internal class FilmsService : IFilmsService
    {
        private readonly IFilmsRepository _repository;
        public FilmsService(IFilmsRepository repository)
        {
            _repository = repository;
        }
        public List<FilmsDTO> GetAllFilms()
        {
            var films_ = _repository.GetAll();
            var filmsDTOs = new List<FilmsDTO>();
            foreach (var films in films_)
            {
                filmsDTOs.Add(FilmsMap.ToDTO(films));
            }
            return filmsDTOs;
        }
        public void AddFilms(FilmsDTO filmsDTO)
        {
            var films = FilmsMap.ToEntity(filmsDTO);
            _repository.Add(films);
        }
        public void RemoveFilms(string title)
        {
            _repository.Remove(title);
        }
        public void UpdateFilms(Films films)
        {
            var existingFilms = _repository.GetByTitle(films.Title);
            if (existingFilms == null)
                throw new ArgumentException("Фильм не найден");
            existingFilms.Update(films.Title, films.Genre, films.ScriptWriter, films.StageDirector, films.Producer, films.ReleaseYear, films.FilmCost);
        }
    }
}
