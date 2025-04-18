﻿// <auto-generated />
using LoginEfCoreWf.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginEfCoreWf.Migrations
{
    [DbContext(typeof(LoginContext))]
    partial class LoginContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("LoginEfCoreWf.Models.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginId");

                    b.ToTable("Logins");
                });
#pragma warning restore 612, 618
        }
    }
}
