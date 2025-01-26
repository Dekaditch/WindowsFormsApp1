using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities.Interfaces
{
    public interface ISupplier
    {
        string Name { get; }
        string LegalAddress { get; }
        string SupplierBank { get; }
        string SupplierBankNumber { get; }
        string SupplierITN { get; }

    }
}
