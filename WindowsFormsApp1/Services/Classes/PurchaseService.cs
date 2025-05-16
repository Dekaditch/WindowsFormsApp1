using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Entities.Interfaces;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Interfaces;

namespace WindowsFormsApp1.Services.Classes
{
        internal class PurchaseService : IPurchaseService
        {
            private readonly IPurchaseRepository _repository;
            public PurchaseService(IPurchaseRepository repository)
            {
                _repository = repository;
            }
            public List<PurchaseDTO> GetAllPurchases()
            {
                var purchases = _repository.GetAll();
                var purchaseDTOs = new List<PurchaseDTO>();
                foreach (var purchase in purchases)
                {
                    purchaseDTOs.Add(PurchaseMap.ToDTO(purchase));
                }
                return purchaseDTOs;
            }
            public void AddPurchase(PurchaseDTO purchaseDTO)
            {
                var purchase = PurchaseMap.ToEntity(purchaseDTO);
                _repository.Add(purchase);
            }
            public void RemovePurchase(int Id)
            {
                _repository.Remove(Id);
            }
            public void UpdatePurchase(Purchase purchase)
            {
                var existingPurchase = _repository.GetByID(purchase.PurchaseID);
                if (existingPurchase == null)
                    throw new ArgumentException("Покупка не найдена");
                existingPurchase.Update(purchase.Films, purchase.Supplier, 
                    purchase.PurchaseDate, purchase.PurchaseCost, purchase.PurchaseID);
            }

            public PurchaseDTO GetPurchaseByID(int purchaseID)
            {
                var purchases = _repository.GetAll();
                foreach (var purchase in purchases)
                {
                    if (purchase.PurchaseID == purchaseID)
                        return PurchaseMap.ToDTO(purchase);
                }
                return null;
            }
        }
}
