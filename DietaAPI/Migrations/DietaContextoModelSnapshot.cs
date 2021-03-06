// <auto-generated />
using System;
using DietaAPI.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DietaAPI.Migrations
{
    [DbContext(typeof(DietaContexto))]
    partial class DietaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DietaAPI.Models.Alimento", b =>
                {
                    b.Property<int>("AlimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.Property<int>("TabelaNutricionalId")
                        .HasColumnType("int");

                    b.HasKey("AlimentoId");

                    b.HasIndex("ReceitaId");

                    b.HasIndex("TabelaNutricionalId");

                    b.ToTable("Alimento");
                });

            modelBuilder.Entity("DietaAPI.Models.Receita", b =>
                {
                    b.Property<int>("ReceitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredientes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparatorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TabelaNutricionalId")
                        .HasColumnType("int");

                    b.HasKey("ReceitaId");

                    b.HasIndex("TabelaNutricionalId");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("DietaAPI.Models.TabelaNutricional", b =>
                {
                    b.Property<int>("TabelaNutricionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Açucares")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Calcio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Calorias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carboidrato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colesterol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Energia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ferro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FibraAlimentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gordura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lípidios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proteinas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TabelaNutricionalId");

                    b.ToTable("TabelaNutricional");
                });

            modelBuilder.Entity("DietaAPI.Models.Alimento", b =>
                {
                    b.HasOne("DietaAPI.Models.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietaAPI.Models.TabelaNutricional", "TabelaNutricional")
                        .WithMany()
                        .HasForeignKey("TabelaNutricionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");

                    b.Navigation("TabelaNutricional");
                });

            modelBuilder.Entity("DietaAPI.Models.Receita", b =>
                {
                    b.HasOne("DietaAPI.Models.TabelaNutricional", "TabelaNutricional")
                        .WithMany()
                        .HasForeignKey("TabelaNutricionalId");

                    b.Navigation("TabelaNutricional");
                });
#pragma warning restore 612, 618
        }
    }
}
