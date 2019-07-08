using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBookApp
{
    public class Fruit
    {
        public string Naam { get; set; }
        public DateTime Houdbaarheidsdatum { get; set; }
        public string Filepath { get; set; }

        public override string ToString()
        {
            return Naam + ", " + Houdbaarheidsdatum.ToShortDateString();
        }

    }

}
