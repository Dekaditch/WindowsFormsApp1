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
    public class CinemaRepository : ICinemaRepository
    {
        private readonly string filePath = "cinema.json";
        public void Add(Cinema cinema) 
        {
            var cinemas = GetAll();
            cinemas.Add(cinema);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(cinemas, Formatting.Indented));
        }

        public void Remove(string address)
        {
            var cinemas = GetAll();
            var cinemaToRemove = cinemas.Find(x => x.Address == address);
            if (cinemaToRemove != null)
            {
                cinemas.Remove(cinemaToRemove);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(cinemas, Formatting.Indented));
            }
        }

        public Cinema GetByAddress(string address) 
        {
            var cinemas = GetAll();
            return cinemas.Find(x => x.Address == address);

        }

        public void Update(Cinema cinema)
        {
            var cinemas = GetAll();
            var existingCinema = cinemas.Find(x => x.Address == cinema.Address);
            if (existingCinema != null)
            {
                existingCinema.Update(cinema.Address, cinema.PhoneNumber, cinema.Director, cinema.Owner, cinema.Bank, cinema.BankNumber, cinema.ITN, cinema.Seats);
                File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(cinemas, new JsonSerializerOptions { WriteIndented = true }));
            }
        }


        public List<Cinema> GetAll() 
        {
            if (!File.Exists(filePath)) return new List<Cinema> ();
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Cinema>>(json);
        }
    }
}
