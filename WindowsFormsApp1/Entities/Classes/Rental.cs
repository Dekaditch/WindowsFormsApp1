using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities.Interfaces;

namespace WindowsFormsApp1.Entities
{
    public class Rental : IRental
    {
        public DateTimeOffset DateStart {  get; private set; }
        public DateTimeOffset DateEnd {  get; private set; }
        public Films Films { get; private set; }
        public Cinema Cinema { get; private set; }
        public double Penalty { get; private set; }
        public double RentCost { get; private set; }
        public int RentID { get; private set; }

        

        public Rental(DateTimeOffset dateStart, DateTimeOffset dateEnd, Films films, Cinema cinema, double penalty, double rentCost, int rentID)
        {
            if (dateStart == null && dateStart.Year < Films.ReleaseYear) 
                throw new ArgumentNullException(nameof(dateStart), "Дата начала аренды фильма не может быть NULL и меньше года релиза фильма");
            if (dateEnd == null && dateEnd <= dateStart) 
                throw new ArgumentNullException(nameof(dateEnd), "Дата конца показа фильма не может быть NULL и меньше начала аренды");
            if (films == null)
                throw new ArgumentNullException(nameof(films), "Фильм не может быть NULL");
            if (cinema == null)
                throw new ArgumentNullException(nameof(cinema), "Кинотеатр не может быть NULL");
            if (penalty <= 0) 
                throw new ArgumentException(nameof(penalty), "Стоимость штрафа должна иметь положительное значение");
            if (rentCost <= 0) 
                throw new ArgumentException(nameof(rentCost), "Стоимость аренды фильма должна иметь положительное значение"); if (rentCost <= 0) 
               if (rentID <= 0)
                throw new ArgumentException(nameof(rentID), "ID аренды должен иметь положительное значение");
            DateStart = dateStart;
            DateEnd = dateEnd;
            Films = films;
            Cinema = cinema;
            Penalty = penalty;
            RentCost = rentCost;
            RentID = rentID;
        }
        
        public void Update(DateTimeOffset dateStart, DateTimeOffset dateEnd, Films films, Cinema cinema, double penalty, double rentCost, int rentID) 
        {
            DateStart = dateStart;
            DateEnd = dateEnd;
            Films = films;
            Cinema = cinema;
            Penalty = penalty;
            RentCost = rentCost;
            RentID = rentID;
        }
    }
}
