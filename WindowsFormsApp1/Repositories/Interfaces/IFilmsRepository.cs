using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories.Interfaces
{
    internal interface IFilmsRepository
    {
        void Add(Films films);
        void Update(Films films);
        void Remove(string title);
        Films GetByTitle(string title);
        List<Films> GetAll();
    }
}
