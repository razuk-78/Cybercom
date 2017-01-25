namespace LogInLogOut
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModle : DbContext
    {
        public MyModle()
            : base("name=MyConnection")
        {
        }

        public virtual DbSet<Table> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.BusinussArea)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.RegionWork)
                .IsFixedLength();
        }
    }
}
