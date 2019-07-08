using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoekenEF
{
    //[Table("Uitgeverij")]
    class Uitgeverij
    {
        public int UitgeverijId { get; set; }
        public string Naam { get; set; }
    }
}
