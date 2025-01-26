using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Mappers
{
    public static class SupplierMap
    {
        public static SupplierDTO ToDTO(Supplier supplier) 
        {
            if (supplier == null) return null;
            return new SupplierDTO
            {
                Name = supplier.Name,
                LegalAddress = supplier.LegalAddress,
                SupplierBank = supplier.SupplierBank,
                SupplierBankNumber = supplier.SupplierBankNumber,
                SupplierITN = supplier.SupplierITN
            };
        }
        public static Supplier ToEntity(SupplierDTO supplierDTO) 
        {
            if ( supplierDTO == null ) return null;
            return new Supplier
            (
                supplierDTO.Name,
                supplierDTO.LegalAddress,
                supplierDTO.SupplierBank,
                supplierDTO.SupplierBankNumber,
                supplierDTO.SupplierITN
            );
        }
    }
}
