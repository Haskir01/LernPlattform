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
        public DbSet<Fachgebiet> Fachgebiete=> Set<Fachgebiet>();
        public DbSet<Kurs>Kurse=> Set<Kurs>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kurs>().HasData(
    new Kurs
    {
        Id = 1,
        Bezeichnung = "Fachinformatiker Baden-Württemberg",
        Beschreibung="AP1, AP2 und Wiso",
        Farbe = "#1F3864",
        Reihenfolge = 1
    }
);

            modelBuilder.Entity<Pruefungsbereich>().HasData(
                new Pruefungsbereich
                {
                    Id = 1,
                    Kuerzel = "AP1",
                    KursId = 1,
                    Titel = "Einrichten eines IT-gestützten Arbeitsplatzes",
                    Beschreibung = "Teil 1 der gestreckten Abschlussprüfung",
                    Farbe = "#2E5395",
                    Reihenfolge = 1
                    
                },
                new Pruefungsbereich
                {
                    Id = 2,
                    Kuerzel = "AP2",
                    KursId = 1,
                    Titel = "Systemintegration",
                    Beschreibung = "Teil 2 – Fachrichtung Systemintegration",
                    Farbe = "#1B7F5C",
                    Reihenfolge = 2
                },
                new Pruefungsbereich
                {
                    Id = 3,
                    Kuerzel = "AP2",
                    KursId = 1,
                    Titel = "Anwendungsentwicklung",
                    Beschreibung = "Teil 2 – Fachrichtung Anwendungsentwicklung",
                    Farbe = "#A34700",
                    Reihenfolge = 3
                },
                new Pruefungsbereich
                {
                    Id = 4,
                    KursId = 1,
                    Kuerzel = "WiSo",
                    Titel = "Wirtschafts- und Sozialkunde",
                    Beschreibung = "Teil 2 – 10 Prozent der Gesamtnote",
                    Farbe = "#6B4C9A",
                    Reihenfolge = 4
                }
            );
            SeedFachgebiete(modelBuilder);
        }
        private static void SeedFachgebiete(ModelBuilder mb)
        {
            mb.Entity<Fachgebiet>().HasData(
                // --- Prüfungsvorbereitung und Methodik ---
                new Fachgebiet { Id = 1, Bezeichnung = "Projektmanagement", Reihenfolge = 1 },
                new Fachgebiet { Id = 2, Bezeichnung = "Modellierung", Reihenfolge = 2 },
                new Fachgebiet { Id = 3, Bezeichnung = "Projektprüfung", Reihenfolge = 3 },

                // --- Technik: Arbeitsplatz ---
                new Fachgebiet { Id = 4, Bezeichnung = "Hardware", Reihenfolge = 4 },
                new Fachgebiet { Id = 5, Bezeichnung = "Betriebssysteme", Reihenfolge = 5 },
                new Fachgebiet { Id = 6, Bezeichnung = "Software und KI", Reihenfolge = 6 },

                // --- Netzwerk ---
                new Fachgebiet { Id = 7, Bezeichnung = "Netzwerk", Reihenfolge = 7 },
                new Fachgebiet { Id = 8, Bezeichnung = "Netzwerkdienste", Reihenfolge = 8 },
                new Fachgebiet { Id = 9, Bezeichnung = "Cloud und Virtualisierung", Reihenfolge = 9 },

                // --- Sicherheit ---
                new Fachgebiet { Id = 10, Bezeichnung = "IT-Sicherheit", Reihenfolge = 10 },
                new Fachgebiet { Id = 11, Bezeichnung = "Datenschutz", Reihenfolge = 11 },
                new Fachgebiet { Id = 12, Bezeichnung = "Storage und Backup", Reihenfolge = 12 },
                new Fachgebiet { Id = 13, Bezeichnung = "Verfügbarkeit", Reihenfolge = 13 },

                // --- Systemintegration ---
                new Fachgebiet { Id = 14, Bezeichnung = "Systemadministration", Reihenfolge = 14 },

                // --- Anwendungsentwicklung ---
                new Fachgebiet { Id = 15, Bezeichnung = "Programmierung", Reihenfolge = 15 },
                new Fachgebiet { Id = 16, Bezeichnung = "Datenbanken", Reihenfolge = 16 },
                new Fachgebiet { Id = 17, Bezeichnung = "Softwarearchitektur", Reihenfolge = 17 },
                new Fachgebiet { Id = 18, Bezeichnung = "Softwarequalität", Reihenfolge = 18 },
                new Fachgebiet { Id = 19, Bezeichnung = "Benutzeroberfläche", Reihenfolge = 19 },
                new Fachgebiet { Id = 20, Bezeichnung = "Schnittstellen und Web", Reihenfolge = 20 },
                new Fachgebiet { Id = 21, Bezeichnung = "Werkzeuge und DevOps", Reihenfolge = 21 },

                // --- Sonstige Technik ---
                new Fachgebiet { Id = 22, Bezeichnung = "Cyber-physische Systeme", Reihenfolge = 22 },

                // --- Kaufmännisch und rechtlich ---
                new Fachgebiet { Id = 23, Bezeichnung = "BWL", Reihenfolge = 23 },
                new Fachgebiet { Id = 24, Bezeichnung = "WiSo", Reihenfolge = 24 },
                new Fachgebiet { Id = 25, Bezeichnung = "Recht und Lizenzen", Reihenfolge = 25 },
                new Fachgebiet { Id = 26, Bezeichnung = "Nachhaltigkeit", Reihenfolge = 26 },

                // --- Kunde und Service ---
                new Fachgebiet { Id = 27, Bezeichnung = "Service und Support", Reihenfolge = 27 },
                new Fachgebiet { Id = 28, Bezeichnung = "Kommunikation", Reihenfolge = 28 }
            );
        }
    }
}
