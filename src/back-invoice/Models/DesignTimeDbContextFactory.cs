using System.IO;
using back_mug_invoice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<InvoiceContext>
{
    public InvoiceContext CreateDbContext(string[] args)
    { 
        var builder = new DbContextOptionsBuilder<InvoiceContext>();
        return new InvoiceContext(builder.Options,GetConfiguration());
    }
    static IConfiguration GetConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        return builder.Build();
    }
}