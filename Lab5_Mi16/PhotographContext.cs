namespace Laboratorul6
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhotographContext : DbContext
    {
        public PhotographContext()
            : base("name=Photograph")
        {
        }
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }
    }
}