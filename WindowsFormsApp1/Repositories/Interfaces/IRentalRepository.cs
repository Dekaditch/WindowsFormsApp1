using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories.Interfaces
{
    internal interface IRentalRepository
    {
        void Add(Rental rental);
        void Update(Rental rental);
        void Remove(int ID);
        Rental GetByID(int ID);
        List<Rental> GetAll();
    }
}
