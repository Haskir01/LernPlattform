using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.Domain.Entities
{
    public class Fachgebiet
    {
        public int Id { get; set; }
        public string? Bezeichnung { get; set; }
        public int Reihenfolge { get; set; }
        public List<Thema> Themen { get; set; } = new();
    }
}
