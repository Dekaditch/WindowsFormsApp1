using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.DTOs
{
    public class RentalDTO
    {
        public DateTimeOffset DateStart { get; set; }
        public DateTimeOffset DateEnd { get; set; }
        public FilmsDTO Films { get; set; }
        public CinemaDTO Cinema { get; set; }
        public double Penalty { get; set; }
        public double RentCost { get; set; }
        public int RentID { get; set; }
    }
}
