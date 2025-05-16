using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Services.Interfaces
{
    internal interface IPurchaseService
    {
        List<PurchaseDTO> GetAllPurchases();
        void AddPurchase(PurchaseDTO purchaseDTO);
        void RemovePurchase(int ID);
        void UpdatePurchase(Purchase supplier);
        PurchaseDTO GetPurchaseByID(int ID);
    }
}
