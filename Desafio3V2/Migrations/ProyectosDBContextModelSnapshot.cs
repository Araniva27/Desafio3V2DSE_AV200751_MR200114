﻿// <auto-generated />
using System;
using Desafio3V2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio3V2.Migrations
{
    [DbContext(typeof(ProyectosDBContext))]
    partial class ProyectosDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Desafio3V2.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Desafio3V2.Models.EquipoT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Equipo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Equipo encargado de la programación y desarrollo de software.",
                            Nombre = "Desarrollo"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Equipo encargado del diseño gráfico y experiencia de usuario.",
                            Nombre = "Diseño"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Equipo encargado de la infraestructura y soporte operativo.",
                            Nombre = "Operaciones"
                        });
                });

            modelBuilder.Entity("Desafio3V2.Models.ProyectoT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Proyecto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EquipoId = 1,
                            FechaFin = new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Plataforma Interna"
                        },
                        new
                        {
                            Id = 2,
                            EquipoId = 1,
                            FechaFin = new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Sistema de Automatización"
                        },
                        new
                        {
                            Id = 3,
                            EquipoId = 1,
                            FechaFin = new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Migración de Plataforma"
                        },
                        new
                        {
                            Id = 4,
                            EquipoId = 2,
                            FechaFin = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Rediseño Web Corporativo"
                        },
                        new
                        {
                            Id = 5,
                            EquipoId = 2,
                            FechaFin = new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Identidad Visual Nueva Marca"
                        },
                        new
                        {
                            Id = 6,
                            EquipoId = 2,
                            FechaFin = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Diseño de Aplicación Móvil"
                        },
                        new
                        {
                            Id = 7,
                            EquipoId = 3,
                            FechaFin = new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Optimización de Redes"
                        },
                        new
                        {
                            Id = 8,
                            EquipoId = 3,
                            FechaFin = new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Automatización de Servidores"
                        },
                        new
                        {
                            Id = 9,
                            EquipoId = 3,
                            FechaFin = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Migración de Datos a Nube"
                        });
                });

            modelBuilder.Entity("Desafio3V2.Models.TareaT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Tarea");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Planificación inicial",
                            Estado = "Pendiente",
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Desarrollo de prototipos",
                            Estado = "En Progreso",
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Implementación de módulos",
                            Estado = "Pendiente",
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Pruebas de integración",
                            Estado = "Pendiente",
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Despliegue inicial",
                            Estado = "Pendiente",
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Recolección de requerimientos",
                            Estado = "Pendiente",
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 7,
                            Descripcion = "Diseño del sistema",
                            Estado = "Pendiente",
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 8,
                            Descripcion = "Configuración de servidores",
                            Estado = "En Progreso",
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 9,
                            Descripcion = "Pruebas de rendimiento",
                            Estado = "Pendiente",
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 10,
                            Descripcion = "Lanzamiento del sistema",
                            Estado = "Pendiente",
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 11,
                            Descripcion = "Evaluación de la plataforma actual",
                            Estado = "Pendiente",
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 12,
                            Descripcion = "Planificación de migración",
                            Estado = "En Progreso",
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 13,
                            Descripcion = "Implementación del nuevo sistema",
                            Estado = "Pendiente",
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 14,
                            Descripcion = "Transferencia de datos",
                            Estado = "Pendiente",
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 15,
                            Descripcion = "Pruebas finales",
                            Estado = "Pendiente",
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 16,
                            Descripcion = "Investigación de usuario",
                            Estado = "Pendiente",
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 17,
                            Descripcion = "Creación de wireframes",
                            Estado = "Pendiente",
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 18,
                            Descripcion = "Diseño de interfaz de usuario",
                            Estado = "En Progreso",
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 19,
                            Descripcion = "Implementación de prototipos",
                            Estado = "Pendiente",
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 20,
                            Descripcion = "Pruebas de usabilidad",
                            Estado = "Pendiente",
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 21,
                            Descripcion = "Desarrollo de conceptos",
                            Estado = "Pendiente",
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 22,
                            Descripcion = "Diseño de logo",
                            Estado = "Pendiente",
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 23,
                            Descripcion = "Creación de guías de estilo",
                            Estado = "En Progreso",
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 24,
                            Descripcion = "Elaboración de material promocional",
                            Estado = "Pendiente",
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 25,
                            Descripcion = "Presentación al cliente",
                            Estado = "Pendiente",
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 26,
                            Descripcion = "Diseño de pantallas",
                            Estado = "Pendiente",
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 27,
                            Descripcion = "Creación de iconografía",
                            Estado = "Pendiente",
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 28,
                            Descripcion = "Pruebas de diseño",
                            Estado = "Pendiente",
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 29,
                            Descripcion = "Adaptación a diferentes dispositivos",
                            Estado = "En Progreso",
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 30,
                            Descripcion = "Revisión final de diseño",
                            Estado = "Pendiente",
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 31,
                            Descripcion = "Auditoría de infraestructura",
                            Estado = "Pendiente",
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 32,
                            Descripcion = "Revisión de configuraciones actuales",
                            Estado = "Pendiente",
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 33,
                            Descripcion = "Implementación de mejoras",
                            Estado = "En Progreso",
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 34,
                            Descripcion = "Pruebas de conectividad",
                            Estado = "Pendiente",
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 35,
                            Descripcion = "Documentación de cambios",
                            Estado = "Pendiente",
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 36,
                            Descripcion = "Configuración de herramientas",
                            Estado = "Pendiente",
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 37,
                            Descripcion = "Desarrollo de scripts de automatización",
                            Estado = "Pendiente",
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 38,
                            Descripcion = "Pruebas de integración",
                            Estado = "En Progreso",
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 39,
                            Descripcion = "Documentación del proceso",
                            Estado = "Pendiente",
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 40,
                            Descripcion = "Implementación en producción",
                            Estado = "Pendiente",
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 41,
                            Descripcion = "Selección de plataforma",
                            Estado = "Pendiente",
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 42,
                            Descripcion = "Planificación de migración de datos",
                            Estado = "En Progreso",
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 43,
                            Descripcion = "Ejecución de la migración",
                            Estado = "Pendiente",
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 44,
                            Descripcion = "Pruebas post-migración",
                            Estado = "Pendiente",
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 45,
                            Descripcion = "Documentación de la migración",
                            Estado = "Pendiente",
                            ProyectoId = 9
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Desafio3V2.Models.ProyectoT", b =>
                {
                    b.HasOne("Desafio3V2.Models.EquipoT", "Equipo")
                        .WithMany("Proyectos")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Desafio3V2.Models.TareaT", b =>
                {
                    b.HasOne("Desafio3V2.Models.ProyectoT", "Proyecto")
                        .WithMany("Tareas")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Desafio3V2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Desafio3V2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Desafio3V2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Desafio3V2.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio3V2.Models.EquipoT", b =>
                {
                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Desafio3V2.Models.ProyectoT", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
