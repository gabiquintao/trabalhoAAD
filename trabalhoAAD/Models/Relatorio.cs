using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Relatorio
{
    public int Id { get; set; }

    public byte Tipo { get; set; }

    public string Texto { get; set; } = null!;

    public DateOnly Data { get; set; }

    public int IdServico { get; set; }

    public virtual Servico IdServicoNavigation { get; set; } = null!;
}
