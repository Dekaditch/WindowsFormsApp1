using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Views
{
    internal interface IPurchaseView
    {
        Films Films { get; }
        Supplier Supplier { get; }
        DateTimeOffset PurchaseDate { get; }
        double PurchaseCost { get; }
        void ShowMessage(string message);
        void ClearFields();
        void ClearPurchaseList();
        void AddPurchaseToList(PurchaseDTO purchaseDTO);
    }
}
