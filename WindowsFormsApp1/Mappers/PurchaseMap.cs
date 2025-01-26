using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Mappers
{
    internal class PurchaseMap
    {
        public static PurchaseDTO ToDTO(Purchase purchase) 
        {
            if (purchase == null) return null;
            return new PurchaseDTO
            {
                Films = FilmsMap.ToDTO(purchase.Films),
                Supplier = SupplierMap.ToDTO(purchase.Supplier),
                PurchaseDate = purchase.PurchaseDate,
                PurchaseCost = purchase.PurchaseCost,
            };
        }
        public static Purchase ToEntity(PurchaseDTO purchaseDTO) 
        {
            if (purchaseDTO == null) return null;
            return new Purchase
            (
                FilmsMap.ToEntity(purchaseDTO.Films),
                SupplierMap.ToEntity(purchaseDTO.Supplier),
                purchaseDTO.PurchaseDate,
                purchaseDTO.PurchaseCost
            );
        }
    }
}
