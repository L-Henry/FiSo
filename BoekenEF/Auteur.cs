using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoekenEF
{
    //[Table("Auteur")]
    class Auteur
    {
        public int AuteurId { get; set; }
        public string Naam { get; set; }

    }
}
