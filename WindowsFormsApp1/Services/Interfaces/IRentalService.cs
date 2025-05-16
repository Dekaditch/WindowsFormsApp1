using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Services.Interfaces
{
    internal interface IRentalService
    {
        List<RentalDTO> GetAllRental();
        void AddRental(RentalDTO rentalDTO);
        void RemoveRental(int ID);
        void UpdateRental(Rental rental);
    }
}
