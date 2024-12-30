using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Pagamento
{
    public int Id { get; set; }

    public DateOnly Data { get; set; }

    public byte Metodo { get; set; }

    public int IdOrcamento { get; set; }

    public virtual Orcamento IdOrcamentoNavigation { get; set; } = null!;
}
