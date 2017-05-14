using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ResumeManager.Models;

namespace ResumeManager.Migrations
{
    [DbContext(typeof(ResumeContext))]
    [Migration("20170513182711_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResumeManager.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("HRLastName")
                        .IsRequired();

                    b.Property<string>("HRName")
                        .IsRequired();

                    b.Property<string>("HRPhone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ResumeManager.Models.Competitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birthdate")
                        .IsRequired();

                    b.Property<string>("CASE")
                        .IsRequired();

                    b.Property<string>("Career")
                        .IsRequired();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Complexity")
                        .IsRequired();

                    b.Property<string>("Database")
                        .IsRequired();

                    b.Property<string>("Education")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Experience")
                        .IsRequired();

                    b.Property<string>("FillingDate")
                        .IsRequired();

                    b.Property<string>("Hobby")
                        .IsRequired();

                    b.Property<string>("Home")
                        .IsRequired();

                    b.Property<string>("Intensity")
                        .IsRequired();

                    b.Property<string>("Knowledge")
                        .IsRequired();

                    b.Property<string>("Language")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Mark");

                    b.Property<string>("MiddleName")
                        .IsRequired();

                    b.Property<string>("Money")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Network")
                        .IsRequired();

                    b.Property<string>("OS")
                        .IsRequired();

                    b.Property<string>("PL")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("PreferSalary")
                        .IsRequired();

                    b.Property<string>("Prestige")
                        .IsRequired();

                    b.Property<string>("Stability")
                        .IsRequired();

                    b.Property<string>("TeamDev")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Competitors");
                });

            modelBuilder.Entity("ResumeManager.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ResumeManager.Models.Competitor", b =>
                {
                    b.HasOne("ResumeManager.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
