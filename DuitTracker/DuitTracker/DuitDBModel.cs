using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DuitTracker
{
    public partial class DuitDBModel : DbContext
    {
        public DuitDBModel()
            : base("name=DuitTrackerDBModel")
        {
        }

        public virtual DbSet<Transaksi> Transaksis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
