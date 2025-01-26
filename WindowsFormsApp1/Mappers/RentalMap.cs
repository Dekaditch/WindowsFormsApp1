using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Mappers
{
    public static class RentalMap
    {
        public static RentalDTO ToDTO(Rental rental) 
        {
            if (rental == null) return null;
            return new RentalDTO
            {
                DateStart = rental.DateStart,
                DateEnd = rental.DateEnd,
                Films = FilmsMap.ToDTO((Films)rental.Films),
                Cinema = CinemaMap.ToDTO((Cinema)rental.Cinema),
                Penalty = rental.Penalty,
                RentCost = rental.RentCost
            };
        }
        public static Rental ToEntity(RentalDTO rentalDTO) 
        {
            if(rentalDTO == null) return null;
            return new Rental
            (
                rentalDTO.DateEnd,
                rentalDTO.DateStart,
                FilmsMap.ToEntity(rentalDTO.Films),
                CinemaMap.ToEntity(rentalDTO.Cinema),
                rentalDTO.Penalty,
                rentalDTO.RentCost
            );
        }
    }
}
