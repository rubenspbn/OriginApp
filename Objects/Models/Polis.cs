using System;
using System.Collections.Generic;

namespace Objects.Models
{
    public class Polis
    {
        public Guid Id { get; set; }
        public string Referentie { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Nummer { get; set; }
        public Dossier Dossier { get; set; }
        public string LaatsteAvenant { get; set; }
        public string Verzekeraar { get; set; }
        public string VerzekeringNemer { get; set; }
        public List<string> Verzekerden { get; set; }
        public string Makelaar { get; set; }
        public string Opdrachttype { get; set; }
    }
}
