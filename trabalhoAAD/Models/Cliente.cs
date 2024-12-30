using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public enum TipoCliente
{
    Empresa,
    Particular
}

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public bool Tipo { get; set; }

    public string Email { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public int IdMorada { get; set; }

    public virtual ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

    public virtual Morada IdMoradaNavigation { get; set; } = null!;

    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
