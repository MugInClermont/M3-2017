using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace back_mug_invoice.Models
{
    public class InvoiceContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        private IConfiguration _configuration;

        public InvoiceContext(DbContextOptions<InvoiceContext> options, IConfiguration configuration) 
        : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Invoice>(ConfigureInvoice);
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlConnectionString = _configuration.GetConnectionString("DataAccessProvider");

            optionsBuilder.UseSqlite(sqlConnectionString);

            base.OnConfiguring(optionsBuilder);
        }


        private void ConfigureInvoice(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");
            builder.HasKey(m => m.InvoiceID);
            builder.Property(ci => ci.InvoiceID)
                .IsRequired();
        }
    }
}