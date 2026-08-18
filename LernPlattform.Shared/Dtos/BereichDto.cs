using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.Shared.Dtos
{
    public  class BereichDto
    {
        public int Id { get; set; }
        public string Kuerzel { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public string? Beschreibung { get; set; }
        public string Farbe { get; set; } = "#2E5395";
    }
}
