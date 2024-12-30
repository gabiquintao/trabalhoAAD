using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Orcamento
{
    public int Id { get; set; }

    public int Valor { get; set; }

    public int IdServico { get; set; }

    public virtual Servico IdServicoNavigation { get; set; } = null!;

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
