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
    internal class CinemaPresenter
    {
        private readonly ICinemaService _cinemaService;
        private readonly ICinemaView _cinemaView;
        public CinemaPresenter(ICinemaService cinemaService, ICinemaView cinemaView)
        {
            _cinemaService = cinemaService;
            _cinemaView = cinemaView;
        }
        public void LoadCinema()
        {
            var cinemas = _cinemaService.GetAllCinemas();
            _cinemaView.ClearCinemaList();
            foreach (var cinema in cinemas)
            {
                _cinemaView.AddCinemaToList(cinema);
            }
        }
        public void AddCinema(CinemaDTO cinemaDTO)
        {
            _cinemaService.AddCinema(cinemaDTO);
            LoadCinema();
        }
        public void RemoveCinema(string address)
        {
            _cinemaService.RemoveCinema(address);
            LoadCinema();
        }
        public void UpdateCinema(CinemaDTO cinemaDTO)
        {
            var cinema = CinemaMap.ToEntity(cinemaDTO);
            _cinemaService.UpdateCinema(cinema);
            LoadCinema();
        }
        public List<CinemaDTO> GetAllCinema()
        {
            return _cinemaService.GetAllCinemas();
        }
    }
}
