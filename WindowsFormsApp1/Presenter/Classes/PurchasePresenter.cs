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
    internal class PurchasePresenter
    {
        private readonly IPurchaseService _rentalService;
        private readonly IPurchaseView _rentalView;
        public PurchasePresenter(IPurchaseService rentalService, IPurchaseView rentalView)
        {
            _rentalService = rentalService;
            _rentalView = rentalView;
        }
        public void LoadPurchase()
        {
            var rentals = _rentalService.GetAllPurchases();
            _rentalView.ClearPurchaseList();
            foreach (var rental in rentals)
            {
                _rentalView.AddPurchaseToList(rental);
            }
        }
        public void AddPurchase(PurchaseDTO rentalDTO)
        {
            _rentalService.AddPurchase(rentalDTO);
            LoadPurchase();
        }
        public void RemovePurchase(int id)
        {
            _rentalService.RemovePurchase(id);
            LoadPurchase();
        }
        public void UpdatePurchase(PurchaseDTO rentalDTO)
        {
            var rental = PurchaseMap.ToEntity(rentalDTO);
            _rentalService.UpdatePurchase(rental);
            LoadPurchase();
        }
        public List<PurchaseDTO> GetAllPurchase()
        {
            return _rentalService.GetAllPurchases();
        }
    }
}
