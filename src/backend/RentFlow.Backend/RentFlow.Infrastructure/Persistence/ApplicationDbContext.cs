using Microsoft.EntityFrameworkCore;
using RentFlow.Domain.Entities; // Necesitaremos crear esto en el paso 13

namespace RentFlow.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Aquí registramos las tablas del sistema
    public DbSet<Tenant> Tenants { get; set; }
}