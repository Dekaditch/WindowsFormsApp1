using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories.Interfaces
{
    internal interface IPurchaseRepository
    {
        void Add(Purchase purchase);
        void Update(Purchase purchase);
        void Remove(int ID);
        Purchase GetByID(int ID);
        List<Purchase> GetAll();
    }
}
