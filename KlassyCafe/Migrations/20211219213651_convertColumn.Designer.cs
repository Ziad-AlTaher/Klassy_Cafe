﻿// <auto-generated />
using System;
using KlassyCafe.NewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KlassyCafe.Migrations
{
    [DbContext(typeof(KlassyCafeContext))]
    [Migration("20211219213651_convertColumn")]
    partial class convertColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KlassyCafe.NewModel.TbCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("TbCategories");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbEmployee", b =>
                {
                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("JopId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true);

                    b.Property<int>("NationalId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasIndex("JopId");

                    b.ToTable("TbEmployee");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,4)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((1))");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbInvoices");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbItem", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Disciption")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ItemName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("SalesPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TbItems");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbJop", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TbJops");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool?>("Canceled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DateTimeNow")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Delevered")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("DeleveryDateTime")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId")
                        .HasName("PK_TbDelevery");

                    b.ToTable("TbOrders");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbReservation", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("ReservationId")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .IsFixedLength(true);

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Message")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("NGuests")
                        .HasColumnType("int")
                        .HasColumnName("N_Guests");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.Property<DateTime?>("TimeSent")
                        .HasColumnType("datetime");

                    b.HasKey( "ReservationId")
                        .HasName("PK_Reservation");

                    b.ToTable("TbReservation");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbSlider", b =>
                {
                    b.Property<int>("SliderId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SliderId");

                    b.ToTable("TbSlider");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.VwInvDatum", b =>
                {
                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DeleveryDateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,4)");

                    b.Property<string>("ItemName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.Property<decimal?>("SalesPrice")
                        .HasColumnType("decimal(18,4)");

                    b.ToView("VwInvData");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.VwItemCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Disciption")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("SalesPrice")
                        .HasColumnType("decimal(18,4)");

                    b.ToView("VwItemCategory");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbEmployee", b =>
                {
                    b.HasOne("KlassyCafe.NewModel.TbJop", "Jop")
                        .WithMany()
                        .HasForeignKey("JopId")
                        .HasConstraintName("FK_TbEmployee_TbJops");

                    b.Navigation("Jop");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbInvoice", b =>
                {
                    b.HasOne("KlassyCafe.NewModel.TbOrder", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_TbInvoices_TbOrders")
                        .IsRequired();

                    b.HasOne("KlassyCafe.NewModel.TbItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbInvoices_TbItems")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbItem", b =>
                {
                    b.HasOne("KlassyCafe.NewModel.TbCategory", "Category")
                        .WithMany("TbItems")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_TbItems_TbCategories");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KlassyCafe.NewModel.TbCategory", b =>
                {
                    b.Navigation("TbItems");
                });
#pragma warning restore 612, 618
        }
    }
}
