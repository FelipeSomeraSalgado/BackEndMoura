using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NovoCrudMoura.Models;

[Table("Aluno")]
public partial class Aluno
{
    [Key]
    [Column("ID")]
    public int ID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Column("CPF")]
    [StringLength(14)]
    [Unicode(false)]
    public string CPF { get; set; } = null!;

    public int Idade { get; set; }

    [Column("EMail")]
    [StringLength(255)]
    public string EMail { get; set; } = null!;
}
