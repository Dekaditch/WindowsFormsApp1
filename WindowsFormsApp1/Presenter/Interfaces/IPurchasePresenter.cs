using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Presenter.Interfaces
{
    internal interface IPurchasePresenter
    {
        void LoadPurchase();
        void AddPurchase(PurchaseDTO PurchaseDTO);
        void RemovePurchase(int PurchaseID);
        void UpdatePurchase(PurchaseDTO PurchaseDTO);
        List<PurchaseDTO> GetAllPurchase();
    }
}
