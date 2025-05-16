using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Services.Interfaces
{
    internal interface IFilmsService
    {
        List<FilmsDTO> GetAllFilms();
        void AddFilms(FilmsDTO filmsDTO);
        void RemoveFilms(string title);
        void UpdateFilms(Films films);
        FilmsDTO GetFilmsByTitle(string title);
    }
}
