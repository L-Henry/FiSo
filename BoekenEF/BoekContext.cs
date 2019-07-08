using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenEF
{
    class BoekContext : DbContext
    {
        public DbSet<Boek> Boeken { get; set; }
        public DbSet<Auteur> Auteur { get; set; }
        public DbSet<Uitgeverij> Uitgever { get; set; }

        public BoekContext(): base("Boeken")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Boeken>().ToTable("Boeken");
            modelBuilder.Entity<Boeken>().HasRequired(b => b.UitgeverijId);
            modelBuilder.Entity<Boeken>().HasRequired(b => b.AuteurId);

            modelBuilder.Entity<Auteur>().ToTable("Auteur");
            modelBuilder.Entity<Uitgeverij>().ToTable("Uitgeverij");
            */

            base.OnModelCreating(modelBuilder);


        }


    }
}
