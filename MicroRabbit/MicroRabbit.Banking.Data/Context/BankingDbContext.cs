using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    // -s startup-project set to API where inject the context
    // -p where to create the migrations
    // -c context to use for the command
    // dotnet ef migrations add InitialCreate -c BankingDbContext -p Microrabbit.Banking.Data -s MicroRabbit.Banking.Api
    // dotnet ef database update -c BankingDbContext -p Microrabbit.Banking.Data -s MicroRabbit.Banking.Api
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}