using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace esercizioS18L1.Models
{
    public class Spedizione
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Mittente { get; set; }
        public string CodiceSpedizione { get; set; }
        public string NomeDestinatario { get; set; }
        public string IndirizzoDestinazione { get; set; }
        public string CittaDestinazione { get; set; }
        public decimal Costo { get; set; }
        public decimal PesoKg { get; set; }
        [Required]
        [Display(Name = "Data Spedizione")]
        [DataType(DataType.DateTime)]
        public DateTime DataSpedizione { get; set; }

        [Required]
        [Display(Name = "Data Stimata Consegna")]
        [DataType(DataType.DateTime)]
        public DateTime DataStimataConsegna { get; set; }

        public List<Stato> Stati { get; set; }
    }

    public class Stato
    {
        public int Id { get; set; }
        public int SpedizioneId { get; set; }
        public string Aggiornamento { get; set; }
        public string Luogo { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataOraAggiornamento { get; set; }
    }
}
