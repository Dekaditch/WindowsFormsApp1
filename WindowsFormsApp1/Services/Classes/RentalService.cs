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
    internal class RentalService : IRentalService
    {
        private readonly IRentalRepository _repository;
        public RentalService(IRentalRepository repository)
        {
            _repository = repository;
        }
        public List<RentalDTO> GetAllRental()
        {
            var rentals = _repository.GetAll();
            var rentalDTOs = new List<RentalDTO>();
            foreach (var rental in rentals)
            {
                rentalDTOs.Add(RentalMap.ToDTO(rental));
            }
            return rentalDTOs;
        }
        public void AddRental(RentalDTO rentalDTO)
        {
            var rental = RentalMap.ToEntity(rentalDTO);
            _repository.Add(rental);
        }
        public void RemoveRental(int Id)
        {
            _repository.Remove(Id);
        }
        public void UpdateRental(Rental rental)
        {
            var existingRental = _repository.GetByID(rental.RentID);
            if (existingRental == null)
                throw new ArgumentException("Аренда не найдена");
            existingRental.Update(rental.DateStart, rental.DateEnd,
                rental.Films, rental.Cinema, rental.Penalty, rental.RentCost, rental.RentID);
        }

        public RentalDTO GetRentalByID(int rentalID)
        {
            var rentals = _repository.GetAll();
            foreach (var rental in rentals)
            {
                if (rental.RentID == rentalID)
                    return RentalMap.ToDTO(rental);
            }
            return null;
        }
    }
}
