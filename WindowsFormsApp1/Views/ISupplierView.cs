using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    internal interface ISupplierView
    {
        string Name { get;}
        string LegalAddress { get;}
        string SupplierBank { get; }
        string SupplierBankNumber { get; }
        string SupplierITN { get; }

        void ShowMessage(string message);
        void ClearFields();
        void ClearSupplierList();
        void AddSupplierToList(SupplierDTO supplierDTO);
    }
}
