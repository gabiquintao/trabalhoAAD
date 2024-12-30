using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Fornecedor
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public int IdMorada { get; set; }

    public virtual Morada IdMoradaNavigation { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
