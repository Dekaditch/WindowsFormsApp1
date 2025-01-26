using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Mappers
{
    public static class FilmsMap
    {
        public static FilmsDTO ToDTO(Films films) 
        {
            if (films == null) return null;
            return new FilmsDTO
            {
                Title = films.Title,
                Genre = films.Genre,
                ScriptWriter = films.ScriptWriter,
                StageDirector = films.StageDirector,
                Producer = films.Producer,
                ReleaseYear = films.ReleaseYear,
                FilmCost = films.FilmCost,
            };
        }
        public static Films ToEntity(FilmsDTO filmsDTO) 
        {
            if(filmsDTO == null) return null;
            return new Films
            (
                filmsDTO.Title,
                filmsDTO.Genre,
                filmsDTO.ScriptWriter,
                filmsDTO.StageDirector,
                filmsDTO.Producer,
                filmsDTO.ReleaseYear,
                filmsDTO.FilmCost
            );
        }
    }
}
