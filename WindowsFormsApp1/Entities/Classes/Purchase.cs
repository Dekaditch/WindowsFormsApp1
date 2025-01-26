using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities.Interfaces;

namespace WindowsFormsApp1.Entities
{
    public class Purchase : IPurchase
    {
        public Films Films { get; private set; }
        public Supplier Supplier { get; private set; }
        public DateTimeOffset PurchaseDate { get; private set; }
        public double PurchaseCost {  get; private set; } 

        public Purchase(Films films, Supplier supplier, DateTimeOffset purchaseDate, double purchaseCost) 
        {
            if (films == null) 
               throw new ArgumentNullException(nameof(films), "Фильм не может быть NULL");
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier), "Поставщик не может быть NULL");
            if (purchaseDate == null)
                throw new ArgumentNullException(nameof(purchaseDate), "Дата закупки не может быть NULL");
            if (purchaseCost <= 0)
                throw new ArgumentException(nameof(purchaseDate), "Закупка должна иметь положительное значение");
            Films = films;
            Supplier = supplier;
            PurchaseDate = purchaseDate;
            PurchaseCost = purchaseCost;
        }

        public void Update(Films films, Supplier supplier, DateTimeOffset purchaseDate, double purchaseCost) 
        {
            Films = films;
            Supplier = supplier;
            PurchaseDate = purchaseDate;
            PurchaseCost = purchaseCost;
        }
    }
}
