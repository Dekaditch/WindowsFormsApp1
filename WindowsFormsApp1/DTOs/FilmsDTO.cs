using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTOs
{
    public class FilmsDTO
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ScriptWriter { get;  set; }
        public string StageDirector { get; set; }
        public string Producer { get; set; }
        public int ReleaseYear { get; set; }
        public double FilmCost { get; set; }
    }
}
