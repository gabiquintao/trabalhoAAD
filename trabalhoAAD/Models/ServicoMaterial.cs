using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class ServicoMaterial
{
    public int Quantidade { get; set; }

    public int IdServico { get; set; }

    public int IdMaterial { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;

    public virtual Servico IdServicoNavigation { get; set; } = null!;
}
