using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Mecanico
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public byte Especialidade { get; set; }

    public string Telefone { get; set; } = null!;

    public int IdMorada { get; set; }

    public virtual Morada IdMoradaNavigation { get; set; } = null!;

    public virtual ICollection<Servico> Servicos { get; set; } = new List<Servico>();
}
