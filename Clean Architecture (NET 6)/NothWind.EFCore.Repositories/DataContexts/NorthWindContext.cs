

namespace NothWind.EFCore.Repositories.DataContexts;
internal class NorthWindContext : DbContext
{
  protected override void OnConfiguring(
    DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(
      "Server=EINCIOREMOTE\\MSSQLSERVERUCV19;Database=NortWindNET20;User=sa;Password=04748826");
  }
  public DbSet<Order> Orders { get; set; }
  public DbSet<OrderDetail> OrderDetails { get; set; }

  protected override void OnModelCreating(
    ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(
      Assembly.GetExecutingAssembly());
  }
}
