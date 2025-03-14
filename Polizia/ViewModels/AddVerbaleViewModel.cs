﻿namespace Polizia.ViewModels
{
    public class AddVerbaleViewModel
    {
        public DateTime DataViolazione { get; set; }
        public string? IndirizzoViolazione { get; set; }
        public string? NominativoAgente { get; set; }
        public DateTime DataTrascrizioneVerbale { get; set; }
        public decimal Importo { get; set; }
        public int? DecurtamentoPunti { get; set; }
        public int IdAnagrafica { get; set; }
        public int IdViolazione { get; set; }

    }
}
