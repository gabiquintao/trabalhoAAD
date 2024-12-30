using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Servico
{
    public int Id { get; set; }

    public byte Tipo { get; set; }

    public DateOnly DataInicio { get; set; }

    public DateOnly DataFim { get; set; }

    public bool Estado { get; set; }

    public int IdMecanico { get; set; }

    public int IdVeiculo { get; set; }

    public virtual Mecanico IdMecanicoNavigation { get; set; } = null!;

    public virtual Veiculo IdVeiculoNavigation { get; set; } = null!;

    public virtual ICollection<Orcamento> Orcamentos { get; set; } = new List<Orcamento>();

    public virtual ICollection<Relatorio> Relatorios { get; set; } = new List<Relatorio>();
}
