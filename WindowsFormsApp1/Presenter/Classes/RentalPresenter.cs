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
    internal class RentalPresenter
    {
        private readonly IRentalService _rentalService;
        private readonly IRentalView _rentalView;
        public RentalPresenter(IRentalService rentalService, IRentalView rentalView)
        {
            _rentalService = rentalService;
            _rentalView = rentalView;
        }
        public void LoadRental()
        {
            var rentals = _rentalService.GetAllRental();
            _rentalView.ClearRentalList();
            foreach (var rental in rentals)
            {
                _rentalView.AddRentalToList(rental);
            }
        }
        public void AddRental(RentalDTO rentalDTO)
        {
            _rentalService.AddRental(rentalDTO);
            LoadRental();
        }
        public void RemoveRental(int id)
        {
            _rentalService.RemoveRental(id);
            LoadRental();
        }
        public void UpdateRental(RentalDTO rentalDTO)
        {
            var rental = RentalMap.ToEntity(rentalDTO);
            _rentalService.UpdateRental(rental);
            LoadRental();
        }
        public List<RentalDTO> GetAllRents()
        {
            return _rentalService.GetAllRental();
        }
    }
}
