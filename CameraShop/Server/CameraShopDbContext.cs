using Microsoft.EntityFrameworkCore;
using CameraShop.Shared;

namespace CameraShop.Server
{
    public class CameraShopDbContext : DbContext
    {
        public CameraShopDbContext(DbContextOptions<CameraShopDbContext> options)
          : base(options) { }

        public DbSet<Camera> Cameras { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var cameraEntity = modelBuilder.Entity<Camera>();
            cameraEntity.HasKey(camera => camera.Id);
            cameraEntity.Property(camera => camera.Name)
            .HasMaxLength(80);
            cameraEntity.Property(camera => camera.Price)
            .HasColumnType("money");
            cameraEntity.Property(camera => camera.Lens)
            .HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Cameras)
            .WithMany(camera => camera.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.Id);
            customerEntity.Property(customer => customer.Name)
            .HasMaxLength(100);
            customerEntity.Property(customer => customer.Street)
            .HasMaxLength(50);
            customerEntity.Property(customer => customer.City)
            .HasMaxLength(50);
        }
    }
}
