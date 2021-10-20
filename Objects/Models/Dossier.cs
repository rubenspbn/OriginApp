using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.Models
{
    public class Dossier
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string SubDossier { get; set; }
        public string Nummer { get; set; }
        public DateTime KlassementDatum { get; set; }
        public string Naam { get; set; }
        public string Details { get; set; }
        public Locatie Locatie { get; set; }
        public int Kastnummer { get; set; }
        public int Rijnummer { get; set; }
        public int Planknummer { get; set; }
        public string GeleendDoor { get; set; }
    }
}
