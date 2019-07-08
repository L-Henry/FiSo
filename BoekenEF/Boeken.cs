using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenEF
{
    //[Table("Boeken")]
    class Boek
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titel { get; set; }

        public int PaginaAantal { get; set; }
        public virtual Auteur Auteur { get; set; }
        public virtual Uitgeverij Uitgeverij { get; set; }

    }
}
