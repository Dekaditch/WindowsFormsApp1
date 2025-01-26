using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using WindowsFormsApp1.Entities;
using System.Net;
using System.Text.Json;
using WindowsFormsApp1.Repositories.Interfaces;


namespace WindowsFormsApp1.Repositories.Classes
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly string filePath = "supplier.json";
        public void Add(Supplier supplier)
        {
            var suppliers = GetAll();
            suppliers.Add(supplier);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(suppliers, Formatting.Indented));
        }

        public void Remove(string name)
        {
            var suppliers = GetAll();
            var suppliersToRemove = suppliers.Find(x => x.Name == name);
            if (suppliersToRemove != null)
            {
                suppliers.Remove(suppliersToRemove);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(suppliers, Formatting.Indented));
            }
        }

        public Supplier GetByName(string name)
        {
            var suppliers = GetAll();
            return suppliers.Find(x => x.Name == name);

        }

        public void Update(Supplier supplier)
        {
            var suppliers = GetAll();
            var existingSupplier = suppliers.Find(x => x.Name == supplier.Name);
            if (existingSupplier != null)
            {
                existingSupplier.Update(supplier.Name, supplier.LegalAddress, supplier.SupplierBank, supplier.SupplierBankNumber, supplier.SupplierITN);
                File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(suppliers, new JsonSerializerOptions { WriteIndented = true }));
            }
        }


        public List<Supplier> GetAll()
        {
            if (!File.Exists(filePath)) return new List<Supplier>();
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Supplier>>(json);
        }
    }
}
