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
    public class RentalRepository : IRentalRepository
    {
        private readonly string filePath = "rental.json";
        public void Add(Rental rental)
        {
            var rentals = GetAll();
            rentals.Add(rental);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(rentals, Formatting.Indented));
        }
        public void Remove(int id)
        {
            var rentals = GetAll();
            var rentalsToRemove = rentals.Find(x => x.RentID == id);
            if (rentalsToRemove != null)
            {
                rentals.Remove(rentalsToRemove);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(rentals, Formatting.Indented));
            }
        }

        public Rental GetByID(int id)
        {
            var rentals = GetAll();
            return rentals.Find(x => x.RentID == id);

        }

        public void Update(Rental rental)
        {
            var rentals = GetAll();
            var existingRental = rentals.Find(x => x.RentID == rental.RentID);
            if (existingRental != null)
            {
                existingRental.Update(rental.DateStart, 
                    rental.DateEnd, rental.Films, rental.Cinema, 
                    rental.Penalty, rental.RentCost, rental.RentID);
                File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(rentals, new JsonSerializerOptions { WriteIndented = true }));
            }
        }
        public List<Rental> GetAll()
        {
            if (!File.Exists(filePath)) return new List<Rental>();
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Rental>>(json);
        }
    }
}
