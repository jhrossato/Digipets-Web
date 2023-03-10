// <auto-generated />
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
    [Migration("20230312225720_FluentAPIMigration1.2")]
    partial class FluentAPIMigration12
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
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int>("ClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicaId")
                        .IsUnique();

                    b.ToTable("Admin");
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

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Digipets.API.Entities.Clinica", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnOrder(4);

                    b.Property<string>("CRMV")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(3);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(7);

                    b.Property<string>("MAPA")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(5);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnOrder(2);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.ToTable("TB_Clinicas", (string)null);
                });

            modelBuilder.Entity("Digipets.API.Entities.Endereco", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClinicaId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClinicaId")
                        .IsUnique();

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Digipets.API.Entities.Tutor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("CPF")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("Id_Endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("RG");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Tutor");
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

                    b.ToTable("Vacina");
                });

            modelBuilder.Entity("Digipets.API.Entities.Veterinario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("ClinicaId");

                    b.ToTable("Veterinario");
                });

            modelBuilder.Entity("Digipets.API.Entities.Admin", b =>
                {
                    b.HasOne("Digipets.API.Entities.Clinica", "Clinica")
                        .WithOne("Admin")
                        .HasForeignKey("Digipets.API.Entities.Admin", "ClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");
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

            modelBuilder.Entity("Digipets.API.Entities.Endereco", b =>
                {
                    b.HasOne("Digipets.API.Entities.Clinica", "Clinica")
                        .WithOne("Endereco")
                        .HasForeignKey("Digipets.API.Entities.Endereco", "ClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digipets.API.Entities.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Veterinario");
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
                        .WithMany()
                        .HasForeignKey("ClinicaId");

                    b.Navigation("Clinica");
                });

            modelBuilder.Entity("Digipets.API.Entities.Animal", b =>
                {
                    b.Navigation("Vacinas");
                });

            modelBuilder.Entity("Digipets.API.Entities.Clinica", b =>
                {
                    b.Navigation("Admin")
                        .IsRequired();

                    b.Navigation("Endereco")
                        .IsRequired();
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
