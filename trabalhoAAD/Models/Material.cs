using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Material
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int Valor { get; set; }

    public int IdFornecedor { get; set; }

    public virtual Fornecedor IdFornecedorNavigation { get; set; } = null!;
}
