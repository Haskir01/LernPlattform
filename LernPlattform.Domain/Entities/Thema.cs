using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.Domain.Entities
{
    public class Thema
    {
        public int Id { get; set; }
        public string Titel { get; set; } = string.Empty;
        public string? Beschreibung { get; set; }
        public int Reihenfolge { get; set; }

        // Fremdschlüssel: zu welcher Kachel gehört das Thema?
        public int PruefungsbereichId { get; set; }
        public Pruefungsbereich? Pruefungsbereich { get; set; }
    }
}
