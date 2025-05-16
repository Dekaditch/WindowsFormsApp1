using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Entities.Interfaces;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Presenter.Interfaces;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenter.Classes
{
    internal class SupplierPresenter : ISupplierPresenter
    {
        private readonly ISupplierService _supplierService;
        public SupplierPresenter(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
    
        public void AddSupplier(SupplierDTO supplierDTO)
        {
            _supplierService.AddSupplier(supplierDTO);
        }
        public void RemoveSupplier(string name)
        {
            _supplierService.RemoveSupplier(name);
        }
        public void UpdateSupplier(SupplierDTO supplierDTO)
        {
            var supplier = SupplierMap.ToEntity(supplierDTO);
            _supplierService.UpdateSupplier(supplier);
        }
        public List<SupplierDTO> GetAllSupplier()
        {
            return _supplierService.GetAllSuppliers();
        }
    }
}
