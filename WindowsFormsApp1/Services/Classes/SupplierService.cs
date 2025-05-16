using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Entities.Interfaces;
using WindowsFormsApp1.Mappers;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Interfaces;

namespace WindowsFormsApp1.Services.Classes
{
    internal class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;
        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }
        public List<SupplierDTO> GetAllSuppliers()
        {
            var suppliers = _repository.GetAll();
            var supplierDTOs = new List<SupplierDTO>();
            foreach (var supplier in suppliers)
            {
                supplierDTOs.Add(SupplierMap.ToDTO(supplier));
            }
            return supplierDTOs;
        }
        public void AddSupplier(SupplierDTO supplierDTO)
        {
            var supplier = SupplierMap.ToEntity(supplierDTO);
            _repository.Add(supplier);
        }
        public void RemoveSupplier(string Name)
        {
            _repository.Remove(Name);
        }
        public void UpdateSupplier(Supplier supplier)
        {
            var existingSupplier = _repository.GetByName(supplier.Name);
            if (existingSupplier == null)
                throw new ArgumentException("Поставщик не найден");
            existingSupplier.Update(supplier.Name, supplier.LegalAddress, supplier.SupplierBank, supplier.SupplierBankNumber, supplier.SupplierITN);
        }

        public SupplierDTO GetSupplierByITN(string supplierITN)
        {
            var suppliers = _repository.GetAll();
            foreach (var supplier in suppliers)
            {
                if (supplier.SupplierITN == supplierITN)
                    return SupplierMap.ToDTO(supplier);
            }
            return null;
        }
    }
}
