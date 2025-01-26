using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities.Interfaces
{
    public interface IPurchase
    {
        Films Films { get; }
        Supplier Supplier { get; }
        DateTimeOffset PurchaseDate { get; }
        double PurchaseCost { get; }
    }
}
