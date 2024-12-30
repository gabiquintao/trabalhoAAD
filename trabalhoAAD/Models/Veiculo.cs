using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Veiculo
{
    public int Id { get; set; }

    public string Matricula { get; set; } = null!;

    public byte Mes { get; set; }

    public short Ano { get; set; }

    public int IdCliente { get; set; }

    public int IdModelo { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Modelo IdModeloNavigation { get; set; } = null!;

    public virtual ICollection<Servico> Servicos { get; set; } = new List<Servico>();
}
