using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity_Famework
{
    class AutoContext: DbContext
    {
        public DbSet<Auto> Autos { get; set; }

        public AutoContext() : base("AutoDatabank")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

    }
}
