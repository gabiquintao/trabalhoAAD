using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Atendente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null;

    public int IdMorada { get; set; }

    public virtual ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

    public virtual Morada IdMoradaNavigation { get; set; } = null!;
}
