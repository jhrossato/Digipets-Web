﻿// <auto-generated />
using System;
using Digipets.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Digipets.API.Migrations
{
    [DbContext(typeof(DigipetsAPIContext))]
    [Migration("20230307043238_FirstMigration2.0")]
    partial class FirstMigration20
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Digipets.API.Entities.Admin", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Senha");

                    b.HasKey("Id");

                    b.ToTable("TB_Admins");
                });

            modelBuilder.Entity("Digipets.API.Entities.Animal", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<bool?>("Castrado")
                        .HasColumnType("bit")
                        .HasColumnName("Castrado");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Especie");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Genero");

                    b.Property<DateTime?>("Nascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Observacao");

                    b.Property<string>("Pelagem")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pelagem");

                    b.Property<string>("Porte")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Porte");

                    b.Property<string>("Raca")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Raca");

                    b.Property<int>("TutorId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Tutor");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("TB_Animais");
                });

            modelBuilder.Entity("Digipets.API.Entities.Clinica", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Admin");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("CRMV")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CRMV");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Email");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("Id_Endereco")
                        .HasColumnType("int")
                        .HasColumnName("Id_Endereco");

                    b.Property<string>("MAPA")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MAPA");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique();

                    b.HasIndex("EnderecoId");

                    b.ToTable("TB_Clinicas");
                });

            modelBuilder.Entity("Digipets.API.Entities.Endereco", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(28)
                        .HasColumnType("nvarchar(28)")
                        .HasColumnName("Bairro");

                    b.Property<int>("CEP")
                        .HasMaxLength(9)
                        .HasColumnType("int")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(28)
                        .HasColumnType("nvarchar(28)")
                        .HasColumnName("Cidade");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Rua");

                    b.HasKey("Id");

                    b.ToTable("TB_Enderecos");
                });

            modelBuilder.Entity("Digipets.API.Entities.Tutor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("CPF")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("RG")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("RG");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Senha");

                    b.Property<string>("Telefone")
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Telefone");

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Veterinario");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("TB_Tutores");
                });

            modelBuilder.Entity("Digipets.API.Entities.Vacina", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Animal");

                    b.Property<DateTime>("DataAplicacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data_Aplicacao");

                    b.Property<int?>("Dose")
                        .HasColumnType("int")
                        .HasColumnName("Dose");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Nome");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("TB_Vacinas");
                });

            modelBuilder.Entity("Digipets.API.Entities.Veterinario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("CRMV")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CRMV");

                    b.Property<int?>("ClinicaId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Clinica");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("ClinicaId");

                    b.ToTable("TB_Veterinarios");
                });

            modelBuilder.Entity("Digipets.API.Entities.Animal", b =>
                {
                    b.HasOne("Digipets.API.Entities.Tutor", "Tutor")
                        .WithMany("Animais")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("Digipets.API.Entities.Clinica", b =>
                {
                    b.HasOne("Digipets.API.Entities.Admin", "Admin")
                        .WithOne("Clinica")
                        .HasForeignKey("Digipets.API.Entities.Clinica", "AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digipets.API.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Digipets.API.Entities.Tutor", b =>
                {
                    b.HasOne("Digipets.API.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Digipets.API.Entities.Veterinario", "Veterinario")
                        .WithMany("Tutores")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Digipets.API.Entities.Vacina", b =>
                {
                    b.HasOne("Digipets.API.Entities.Animal", "Animal")
                        .WithMany("Vacinas")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Digipets.API.Entities.Veterinario", b =>
                {
                    b.HasOne("Digipets.API.Entities.Clinica", "Clinica")
                        .WithMany("Veterinarios")
                        .HasForeignKey("ClinicaId");

                    b.Navigation("Clinica");
                });

            modelBuilder.Entity("Digipets.API.Entities.Admin", b =>
                {
                    b.Navigation("Clinica")
                        .IsRequired();
                });

            modelBuilder.Entity("Digipets.API.Entities.Animal", b =>
                {
                    b.Navigation("Vacinas");
                });

            modelBuilder.Entity("Digipets.API.Entities.Clinica", b =>
                {
                    b.Navigation("Veterinarios");
                });

            modelBuilder.Entity("Digipets.API.Entities.Tutor", b =>
                {
                    b.Navigation("Animais");
                });

            modelBuilder.Entity("Digipets.API.Entities.Veterinario", b =>
                {
                    b.Navigation("Tutores");
                });
#pragma warning restore 612, 618
        }
    }
}
