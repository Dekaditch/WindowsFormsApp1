using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Presenter.Interfaces
{
    public interface ISupplierPresenter
    {
        void LoadSupplier();
        void AddSupplier(SupplierDTO supplierDTO);
        void RemoveSupplier(string name);
        void UpdateSupplier(SupplierDTO supplierDTO);
        List<SupplierDTO> GetAllSupplier();
    }
}
