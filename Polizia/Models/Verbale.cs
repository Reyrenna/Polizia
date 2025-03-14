using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Polizia.Models;

[Table("Verbale")]
public partial class Verbale
{
    [Key]
    public int IdVerbale { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataViolazione { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string IndirizzoViolazione { get; set; } = null!;

    [Column("Nominativo_Agente")]
    [StringLength(50)]
    [Unicode(false)]
    public string NominativoAgente { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DataTrascrizioneVerbale { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Importo { get; set; }

    public int DecurtamentoPunti { get; set; }

    public int IdAnagrafica { get; set; }

    public int IdViolazione { get; set; }

    [ForeignKey("IdAnagrafica")]
    [InverseProperty("Verbales")]
    public virtual Anagrafica IdAnagraficaNavigation { get; set; } = null!;

    [ForeignKey("IdViolazione")]
    [InverseProperty("Verbales")]
    public virtual TipoViolazione IdViolazioneNavigation { get; set; } = null!;
}
