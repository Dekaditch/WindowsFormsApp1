using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories.Interfaces
{
    internal interface ISupplierRepository
    {
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Remove(string name);
        Supplier GetByName(string name);
        List<Supplier> GetAll();
    }
}
