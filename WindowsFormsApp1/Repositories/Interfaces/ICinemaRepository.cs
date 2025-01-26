using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories.Interfaces
{
    internal interface ICinemaRepository
    {
        void Add(Cinema cinema);
        void Update(Cinema cinema);
        void Remove(string address);
        Cinema GetByAddress(string address);
        List<Cinema> GetAll();
    }
}
