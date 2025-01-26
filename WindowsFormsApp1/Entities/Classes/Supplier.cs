using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities.Interfaces;

namespace WindowsFormsApp1.Entities
{
    public class Supplier : ISupplier
    {
        public string Name { get; private set; }
        public string LegalAddress { get; private set; }
        public string SupplierBank { get; private set; }
        public string SupplierBankNumber { get; private set; }
        public string SupplierITN { get; private set; }

        public Supplier(string name, string legalAddress, string supplierBank, string supplierBankNumber, string supplierITN)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name), "Название поставщика не может быть пустым");
            if (string.IsNullOrWhiteSpace(legalAddress)) throw new ArgumentException(nameof(legalAddress), "Юридический адресс поставщика не может быть пустым");
            if (string.IsNullOrWhiteSpace(supplierBank)) throw new ArgumentException(nameof(supplierBank), "Банк поставщика не может быть пустым");
            if (string.IsNullOrWhiteSpace(supplierBankNumber)) throw new ArgumentException(nameof(supplierBankNumber), "Номер счета в банке поставщика не может быть пустым");
            if (string.IsNullOrWhiteSpace(supplierITN)) throw new ArgumentException(nameof(supplierITN), "ИНН поставщика не может быть пустым");
            Name = name;
            LegalAddress = legalAddress;
            SupplierBank = supplierBank;
            SupplierBankNumber = supplierBankNumber;
            SupplierITN = supplierITN;
        }

        public void Update(string name, string legalAddress, string supplierBank, string supplierBankNumber, string supplierITN) 
        {
            Name = name;
            LegalAddress = legalAddress;
            SupplierBank = supplierBank;
            SupplierBankNumber = supplierBankNumber;
            SupplierITN = supplierITN;
        }
    }
}
