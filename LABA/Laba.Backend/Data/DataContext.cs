using Microsoft.EntityFrameworkCore;


public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
            }

            public DbSet<Vehiculo> Vehiculos { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Vehiculo>().HasIndex(c => c.Name).IsUnique();
            }
        }
    }

}
}
