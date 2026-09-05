using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.Domain.Entities
{
    public  class Kurs
    {
        public int Id { get; set; }
        public string? Bezeichnung { get; set; }
        public string? Beschreibung { get; set; }
        public int Reihenfolge { get; set; }
        public bool IsAktiv { get; set; }
        public string Farbe { get; set; } = "#2E5395";
        public List<Pruefungsbereich> Bereiche { get; set; } = new();
    }
}
