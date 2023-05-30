using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web_Digital_Potrfolio.Data;

using Models;

public class DigitalPortfolioContext : IdentityDbContext<User, IdentityRole<long>, long>
{
    public DigitalPortfolioContext(DbContextOptions<DigitalPortfolioContext> options)
        : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<FamilyStatus> FamilyStatuses { get; set; }
}