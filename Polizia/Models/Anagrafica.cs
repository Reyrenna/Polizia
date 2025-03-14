using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Polizia.Models;

[Table("Anagrafica")]
public partial class Anagrafica
{
    [Key]
    public int IdAnagrafica { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nome { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cognome { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Indirizzo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Citta { get; set; }

    [Column("CAP")]
    [StringLength(10)]
    [Unicode(false)]
    public string Cap { get; set; } = null!;

    [Column("Cod_Fisc")]
    [StringLength(16)]
    [Unicode(false)]
    public string CodFisc { get; set; } = null!;

    [InverseProperty("IdAnagraficaNavigation")]
    public virtual ICollection<Verbale> Verbales { get; set; } = new List<Verbale>();
}
