using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.Shared.Dtos
{
    public class KursDto
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; } = "";
        public string Beschreibung { get; set; } = "";
        public string Farbe { get; set; } = "";
    }
}
