using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities.Interfaces
{
    public interface ICinema
    {
        string Address { get; }
        string PhoneNumber { get; }
        string Director { get; }
        string Owner { get;  }
        string Bank { get; }
        string BankNumber { get; }
        string ITN { get; }
        int Seats { get; }
    }
}
