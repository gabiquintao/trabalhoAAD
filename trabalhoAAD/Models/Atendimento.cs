using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Atendimento
{
    public int Id { get; set; }

    public DateOnly Data { get; set; }

    public string Motivo { get; set; } = null;

    public int IdCliente { get; set; }

    public int IdAtendente { get; set; }

    public virtual Atendente IdAtendenteNavigation { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
