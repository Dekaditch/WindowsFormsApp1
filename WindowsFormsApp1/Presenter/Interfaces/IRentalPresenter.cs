using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Presenter.Interfaces
{
    internal interface IRentalPresenter
    {
        void LoadRental();
        void AddRental(RentalDTO rentalDTO);
        void RemoveRental(int rentalID);
        void UpdateRental(RentalDTO rentalDTO);
        List<RentalDTO> GetAllRents();
    }
}
