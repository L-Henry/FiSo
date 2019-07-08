using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace AdventureWorks
{
    public class AWContext: DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public AWContext(): base("AdventureWorks")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("Person.Address");

            base.OnModelCreating(modelBuilder);


        }

    }
}
