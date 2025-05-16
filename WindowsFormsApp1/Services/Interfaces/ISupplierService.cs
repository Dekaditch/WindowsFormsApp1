using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Services.Interfaces
{
    internal interface ISupplierService
    {
        List<SupplierDTO> GetAllSuppliers();
        void AddSupplier(SupplierDTO supplierDTO);
        void RemoveSupplier(string name);
        void UpdateSupplier(Supplier supplier);
        SupplierDTO GetSupplierByITN(string supplierITN);
    }
}
