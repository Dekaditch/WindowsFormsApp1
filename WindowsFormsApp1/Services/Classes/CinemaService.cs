using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Services.Interfaces;

namespace WindowsFormsApp1.Services.Classes
{
    internal class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _repository;
        public CinemaService (ICinemaRepository repository) 
        {
            _repository = repository;
        }
        public List<CinemaDTO> GetAllCinemas() 
        {
            var cinemas = _repository.GetAll();
            var CinemaDTOs = new List<CinemaDTO>();
            foreach(var cinema in cinemas) 
            {
                CinemaDTOs.Add(CinemaMap.ToDTO(cinema));
            }
            return CinemaDTOs;
        }
        public void AddCinema(CinemaDTO cinemaDTO) 
        {
            var cinema = CinemaMap.ToEntity(cinemaDTO);
            _repository.Add(cinema);
        }
        public void RemoveCinema(string address) 
        {
            _repository.Remove(address);
        }
        public void UpdateCinema(Cinema cinema) 
        {
            var existingCinema = _repository.GetByAddress(cinema.Address);
            if (existingCinema == null)
                throw new ArgumentException("Кинотеатр не найден");
            existingCinema.Update(cinema.Address, cinema.PhoneNumber, cinema.Director, cinema.Owner, cinema.Bank, cinema.BankNumber, cinema.ITN, cinema.Seats);
        }
    }
}
