using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities.Interfaces
{
    public interface IFilms
    {
        string Title { get; }
        string Genre { get; }
        string ScriptWriter { get; }
        string StageDirector { get; }
        string Producer { get; }
        int ReleaseYear { get; }
        double FilmCost { get; }
    }
}
