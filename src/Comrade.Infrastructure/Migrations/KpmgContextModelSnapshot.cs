﻿#region

using Comrade.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#endregion

namespace Comrade.Infrastructure.Migrations
{
    [DbContext(typeof(ComradeContext))]
    internal class ComradeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Comrade.Domain.Models.Airplane", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("AIRP_SQ_AIRPLANE")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Codigo")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("AIRP_TX_CODIGO");

                b.Property<string>("DataRegistro")
                    .IsRequired()
                    .HasColumnType("varchar(48)")
                    .HasColumnName("AIRP_DT_REGISTRO");

                b.Property<string>("Modelo")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("AIRP_TX_MODELO");

                b.Property<int>("QuantidadePassageiro")
                    .HasColumnType("int")
                    .HasColumnName("AIRP_QT_PASSAGEIRO");

                b.HasKey("Id");

                b.HasIndex("Codigo")
                    .IsUnique()
                    .HasDatabaseName("IX_AIRPLANE_CODIGO");

                b.ToTable("AIRP_AIRPLANE");
            });

            modelBuilder.Entity("Comrade.Domain.Models.UsuarioSistema", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("USSI_SQ_USUARIO_SISTEMA")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("DataRegistro")
                    .IsRequired()
                    .HasColumnType("varchar(48)")
                    .HasColumnName("USSI_DT_REGISTRO");

                b.Property<string>("Email")
                    .HasMaxLength(255)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("USSI_TX_EMAIL");

                b.Property<string>("Matricula")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("USSI_TX_MATRICULA");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("USSI_TX_NOME");

                b.Property<string>("Senha")
                    .IsRequired()
                    .HasMaxLength(1023)
                    .HasColumnType("varchar(1023)")
                    .HasColumnName("USSI_TX_SENHA");

                b.Property<int>("Situacao")
                    .HasColumnType("int")
                    .HasColumnName("USSI_ST_SITUACAO");

                b.HasKey("Id");

                b.HasIndex("Email")
                    .IsUnique()
                    .HasDatabaseName("IX_USUARIO_SISTEMA_EMAIL")
                    .HasFilter("[USSI_TX_EMAIL] IS NOT NULL");

                b.HasIndex("Matricula")
                    .IsUnique()
                    .HasDatabaseName("IX_USUARIO_SISTEMA_MATRICULA");

                b.ToTable("USSI_USUARIO_SISTEMA");
            });

            modelBuilder.Entity("Comrade.Domain.Models.Views.VwUsuarioSistemaPermissao", b =>
            {
                b.Property<int>("SqUsuarioSistema")
                    .HasColumnType("int")
                    .HasColumnName("USSI_SQ_USUARIO_SISTEMA");

                b.ToView("VW_USSP_USUARIO_SISTEMA_PERMISSAO");
            });
#pragma warning restore 612, 618
        }
    }
}