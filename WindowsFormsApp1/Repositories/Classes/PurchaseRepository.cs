using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.Text.Json;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Entities.Interfaces;
using WindowsFormsApp1.Repositories.Interfaces;

namespace WindowsFormsApp1.Repositories.Classes
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly string filePath = "purchase.json";
        public void Add(Purchase purchase)
        {
            var purchases = GetAll();
            purchases.Add(purchase);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(purchases, Formatting.Indented));
        }
        public void Remove(int id)
        {
            var purchases = GetAll();
            var purchasesToRemove = purchases.Find(x => x.PurchaseID == id);
            if (purchasesToRemove != null)
            {
                purchases.Remove(purchasesToRemove);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(purchases, Formatting.Indented));
            }
        }

        public Purchase GetByID(int id)
        {
            var purchases = GetAll();
            return purchases.Find(x => x.PurchaseID == id);

        }

        public void Update(Purchase purchase)
        {
            var purchases = GetAll();
            var existingPurchase = purchases.Find(x => x.PurchaseID == purchase.PurchaseID);
            if (existingPurchase != null)
            {
                existingPurchase.Update(purchase.Films,
                    purchase.Supplier, purchase.PurchaseDate, 
                    purchase.PurchaseCost, purchase.PurchaseID);
                File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(purchases, new JsonSerializerOptions { WriteIndented = true }));
            }
        }
        public List<Purchase> GetAll()
        {
            if (!File.Exists(filePath)) return new List<Purchase>();
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Purchase>>(json);
        }
    }
}
