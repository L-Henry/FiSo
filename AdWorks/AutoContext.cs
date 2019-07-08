using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace AdWorks
{
    class AutoContext: DbContext
    {
        public DbSet<Address> Addressen { get; set; }

        public AutoContext() : base("AdventureWorks")
        {

        }

    }
}
