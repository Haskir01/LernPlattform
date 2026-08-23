using LernPlattform.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LernPlattform.Api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Pruefungsbereich> Pruefungsbereiche => Set<Pruefungsbereich>();
        public DbSet<Thema> Themen => Set<Thema>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pruefungsbereich>().HasData(
                new Pruefungsbereich
                {
                    Id = 1,
                    Kuerzel = "AP1",
                    Titel = "Einrichten eines IT-gestützten Arbeitsplatzes",
                    Beschreibung = "Teil 1 der gestreckten Abschlussprüfung",
                    Farbe = "#2E5395",
                    Reihenfolge = 1
                },
                new Pruefungsbereich
                {
                    Id = 2,
                    Kuerzel = "AP2",
                    Titel = "Systemintegration",
                    Beschreibung = "Teil 2 – Fachrichtung Systemintegration",
                    Farbe = "#1B7F5C",
                    Reihenfolge = 2
                },
                new Pruefungsbereich
                {
                    Id = 3,
                    Kuerzel = "AP2",
                    Titel = "Anwendungsentwicklung",
                    Beschreibung = "Teil 2 – Fachrichtung Anwendungsentwicklung",
                    Farbe = "#A34700",
                    Reihenfolge = 3
                }
            );
        }
    }
}
