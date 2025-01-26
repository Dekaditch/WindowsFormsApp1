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
    public class FilmsRepository : IFilmsRepository
    {
        private readonly string filePath = "films.json";
        public void Add(Films films)
        {
            var films_ = GetAll();
            films_.Add(films);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(films_, Formatting.Indented));
        }

        public void Remove(string title)
        {
            var films_ = GetAll();
            var films_ToRemove = films_.Find(x => x.Title == title);
            if (films_ToRemove != null)
            {
                films_.Remove(films_ToRemove);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(films_, Formatting.Indented));
            }
        }

        public Films GetByTitle(string title)
        {
            var films_ = GetAll();
            return films_.Find(x => x.Title == title);

        }

        public void Update(Films films)
        {
            var films_ = GetAll();
            var existingFilms = films_.Find(x => x.Title == films.Title);
            if (existingFilms != null)
            {
                existingFilms.Update(films.Title, films.Genre, films.ScriptWriter, films.StageDirector, films.Producer, films.ReleaseYear, films.FilmCost);
                File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(films_, new JsonSerializerOptions { WriteIndented = true }));
            }
        }


        public List<Films> GetAll()
        {
            if (!File.Exists(filePath)) return new List<Films>();
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Films>>(json);
        }
    }
}
