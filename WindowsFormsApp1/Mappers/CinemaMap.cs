using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Mappers
{
    public static class CinemaMap
    {
        public static CinemaDTO ToDTO(Cinema cinema)
        { 
            if (cinema == null) return null;
            return new CinemaDTO
            {
                Address = cinema.Address,
                ITN = cinema.ITN,
                PhoneNumber = cinema.PhoneNumber,
                Bank = cinema.Bank,
                BankNumber = cinema.BankNumber,
                Director = cinema.Director,
                Owner = cinema.Owner,
                Seats = cinema.Seats
            };
        }
        public static Cinema ToEntity(CinemaDTO cinemaDTO) 
        {
            if(cinemaDTO == null) return null;
            return new Cinema
            (
                cinemaDTO.Address,
                cinemaDTO.PhoneNumber,
                cinemaDTO.Director,
                cinemaDTO.Owner,
                cinemaDTO.Bank,
                cinemaDTO.BankNumber,
                cinemaDTO.ITN,
                cinemaDTO.Seats
            );
        }
    }
}