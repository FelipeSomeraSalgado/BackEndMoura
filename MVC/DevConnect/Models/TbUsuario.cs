using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E6164A43A2CF9", IsUnique = true)]
[Index("Nomeusuario", Name = "UQ__tb_usuar__CBB6AA36AF4DD717", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nomecompleto")]
    [StringLength(255)]
    public string Nomecompleto { get; set; } = null!;

    [Column("nomeusuario")]
    [StringLength(50)]
    public string Nomeusuario { get; set; } = null!;

    [Column("email")]
    [StringLength(20)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(255)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_url")]
    [StringLength(255)]
    public string? FotoPerfilUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbComentario> TbComentario { get; set; } = new List<TbComentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtida> TbCurtida { get; set; } = new List<TbCurtida>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacao { get; set; } = new List<TbPublicacao>();

    [ForeignKey("IdUsuarioSeguidor")]
    [InverseProperty("IdUsuarioSeguidor")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguido { get; set; } = new List<TbUsuario>();

    [ForeignKey("IdUsuarioSeguido")]
    [InverseProperty("IdUsuarioSeguido")]
    public virtual ICollection<TbUsuario> IdUsuarioSeguidor { get; set; } = new List<TbUsuario>();
}
