using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Views
{
    internal interface ICinemaView
    {
        string Address { get; }
        string PhoneNumber { get; }
        string Director { get; }
        string Owner { get; }
        string Bank { get; }
        string BankNumber { get; }
        string ITN { get; }
        int Seats { get; }
        void ShowMessage(string message);
        void ClearFields();
        void ClearCinemaList();
        void AddCinemaToList(CinemaDTO cinemaDTO);
    }
}
