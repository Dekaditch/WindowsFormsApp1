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
    internal class CinemaPresenter : ICinemaPresenter
    {
        private readonly ICinemaService _cinemaService;
        public CinemaPresenter(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        public void AddCinema(CinemaDTO cinemaDTO)
        {
            _cinemaService.AddCinema(cinemaDTO);
        }
        public void RemoveCinema(string address)
        {
            _cinemaService.RemoveCinema(address);
        }
        public void UpdateCinema(CinemaDTO cinemaDTO)
        {
            var cinema = CinemaMap.ToEntity(cinemaDTO);
            _cinemaService.UpdateCinema(cinema);
        }
        public List<CinemaDTO> GetAllCinema()
        {
            return _cinemaService.GetAllCinemas();
        }
    }
}
