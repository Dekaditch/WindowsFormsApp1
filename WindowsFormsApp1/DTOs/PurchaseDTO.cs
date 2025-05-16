using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.DTOs
{
    public class PurchaseDTO
    {
        public FilmsDTO Films { get; set; }
        public SupplierDTO Supplier { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
        public double PurchaseCost { get; set; }
        public int PurchaseID { get; set; }
    }
}
