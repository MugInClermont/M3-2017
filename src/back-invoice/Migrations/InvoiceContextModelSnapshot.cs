// <auto-generated />
using back_mug_invoice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace backmuginvoice.Migrations
{
    [DbContext(typeof(InvoiceContext))]
    partial class InvoiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("back_mug_invoice.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID");

                    b.Property<float>("Cost");

                    b.Property<string>("Name");

                    b.Property<string>("Owner");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}
