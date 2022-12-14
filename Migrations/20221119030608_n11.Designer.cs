// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myWpf;

#nullable disable

namespace myWpf.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221119030608_n11")]
    partial class n11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("myWpf.Gorod", b =>
                {
                    b.Property<int>("IdGorod")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("IdGorod");

                    b.ToTable("gorod");
                });

            modelBuilder.Entity("myWpf.Postav", b =>
                {
                    b.Property<int>("IdPostav")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("IdGorod")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("IdUlica")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Telef")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("IdPostav");

                    b.ToTable("postav");
                });

            modelBuilder.Entity("myWpf.Prihod", b =>
                {
                    b.Property<int>("IdPrihod")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<DateTime>("DatPrih")
                        .HasColumnType("DATE");

                    b.Property<int>("IdPostav")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("IdTovar")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("Kolvo")
                        .HasColumnType("INT(4)");

                    b.Property<int>("_IdTovarIdTovar")
                        .HasColumnType("int");

                    b.HasKey("IdPrihod");

                    b.HasIndex("_IdTovarIdTovar");

                    b.ToTable("prihod");
                });

            modelBuilder.Entity("myWpf.Test", b =>
                {
                    b.Property<int>("IdTest")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("IdTest");

                    b.ToTable("test");
                });

            modelBuilder.Entity("myWpf.Tovar", b =>
                {
                    b.Property<int>("IdTovar")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("Cena")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("Edizm")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("IdTovar");

                    b.ToTable("tovar");
                });

            modelBuilder.Entity("myWpf.Ulica", b =>
                {
                    b.Property<int>("IdUlica")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("IdUlica");

                    b.ToTable("ulica");
                });

            modelBuilder.Entity("myWpf.Prihod", b =>
                {
                    b.HasOne("myWpf.Tovar", "_IdTovar")
                        .WithMany("prihod")
                        .HasForeignKey("_IdTovarIdTovar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_IdTovar");
                });

            modelBuilder.Entity("myWpf.Tovar", b =>
                {
                    b.Navigation("prihod");
                });
#pragma warning restore 612, 618
        }
    }
}
