using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Repositories.Interfaces;

namespace WindowsFormsApp1.Services.Interfaces
{
    internal interface ICinemaService
    {
        List<CinemaDTO> GetAllCinemas();
        void AddCinema(CinemaDTO cinemaDTO);
        void RemoveCinema(string address);
        void UpdateCinema(Cinema cinema);

    }
}
