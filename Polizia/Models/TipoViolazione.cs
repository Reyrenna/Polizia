using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Polizia.Models;

[Table("TipoViolazione")]
public partial class TipoViolazione
{
    [Key]
    public int IdViolazione { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string Descrizione { get; set; } = null!;

    [InverseProperty("IdViolazioneNavigation")]
    public virtual ICollection<Verbale> Verbales { get; set; } = new List<Verbale>();
}
