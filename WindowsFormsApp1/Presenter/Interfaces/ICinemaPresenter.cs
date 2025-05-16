using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Presenter.Interfaces
{
    public interface ICinemaPresenter
    {
        void AddCinema(CinemaDTO cinemaDTO);
        void RemoveCinema(string address);
        void UpdateCinema(CinemaDTO cinemaDTO);
        List<CinemaDTO> GetAllCinema();
    }
}
