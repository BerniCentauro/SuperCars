namespace Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SuperCarsModel : DbContext
    {
        public SuperCarsModel()
            : base("name=SuperCarsEntities")
        {
        }

        public virtual DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Url)
                .IsUnicode(false);
        }
    }
}
