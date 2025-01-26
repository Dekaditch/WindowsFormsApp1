using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Views
{
    internal interface IRentalView
    {
        DateTimeOffset DateStart { get; }
        DateTimeOffset DateEnd { get; }
        Films Films { get; }
        Cinema Cinema { get; }
        double Penalty { get; }
        double RentCost { get; }
        void ShowMessage(string message);
        void ClearFields();
        void ClearRentalList();
        void AddRentalToList(RentalDTO rentalDTO);
    }
}
