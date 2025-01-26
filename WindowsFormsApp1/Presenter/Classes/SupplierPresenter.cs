using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Entities.Interfaces;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Services.Interfaces;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenter.Classes
{
    internal class SupplierPresenter
    {
        private readonly ISupplierService _supplierService;
        private readonly ISupplierView _supplierView;
        public SupplierPresenter(ISupplierService supplierService, ISupplierView supplierView)
        {
            _supplierService = supplierService;
            _supplierView = supplierView;
        }
        public void LoadSupplier()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            _supplierView.ClearSupplierList();
            foreach (var supplier in suppliers)
            {
                _supplierView.AddSupplierToList(supplier);
            }
        }
        public void AddSupplier(SupplierDTO supplierDTO)
        {
            _supplierService.AddSupplier(supplierDTO);
            LoadSupplier();
        }
        public void RemoveSupplier(string name)
        {
            _supplierService.RemoveSupplier(name);
            LoadSupplier();
        }
        public void UpdateSupplier(SupplierDTO supplierDTO)
        {
            var supplier = SupplierMap.ToEntity(supplierDTO);
            _supplierService.UpdateSupplier(supplier);
            LoadSupplier();
        }
        public List<SupplierDTO> GetAllSupplier()
        {
            return _supplierService.GetAllSuppliers();
        }
    }
}
