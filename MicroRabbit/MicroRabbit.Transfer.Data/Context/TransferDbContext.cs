using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    // -s startup-project set to API where inject the context
    // -p where to create the migrations
    // -c context to use for the command
    // dotnet ef migrations add InitialCreate -c TransferDbContext -p Microrabbit.Transfer.Data -s MicroRabbit.Transfer.Api
    // dotnet ef database update -c TransferDbContext -p Microrabbit.Transfer.Data -s MicroRabbit.Transfer.Api
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}