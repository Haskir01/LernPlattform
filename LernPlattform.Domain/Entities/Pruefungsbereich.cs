using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.Domain.Entities
{
    public class Pruefungsbereich
    {
        public int Id { get; set; } 
        public string? Kuerzel {  get; set; }
        public string? Titel {  get; set; }
        public string? Beschreibung {  get; set; }

        // Farbe der Kachel
        public string Farbe { get; set; } = "#2E5395";

        // Reihenfolge der Kacheln
        public int Reihenfolge { get; set; }

        public List<Thema> Themen { get; set; } = new();
    }
}
