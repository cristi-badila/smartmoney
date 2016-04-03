using System.Data.Entity;

namespace SmartMoneyJobRunner.Models
{
    public class SmartMoneyDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Estimation> Estimations { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public SmartMoneyDbContext()
            : base("SmartMoneyConnectionString")
        {        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PointOfInterest>()
                .HasMany(pointOfInterest => pointOfInterest.Stops)
                .WithMany(stop => stop.PointsOfInterest)
                .Map(cs =>
                {
                    cs.MapLeftKey("pointOfInterestId");
                    cs.MapRightKey("stopId");
                    cs.ToTable("PointOfInterestStops");
                });
            modelBuilder.Entity<PointOfInterest>()
                .HasMany(pointOfInterest => pointOfInterest.Categories)
                .WithMany()
                .Map(cs =>
                {
                    cs.MapLeftKey("pointOfInterestId");
                    cs.MapRightKey("categoryId");
                    cs.ToTable("PointOfInterestCategories");
                });
        }
    }
}