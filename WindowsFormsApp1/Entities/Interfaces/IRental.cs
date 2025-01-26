using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities.Interfaces
{
    public interface IRental
    {
        DateTimeOffset DateStart { get; }
        DateTimeOffset DateEnd { get; }
        Films Films { get; }
        Cinema Cinema { get; }
        double Penalty { get; }
        double RentCost { get; }
    }
}
