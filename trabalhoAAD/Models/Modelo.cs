using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Modelo
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public byte TipoCombustivel { get; set; }

    public int IdMarca { get; set; }

    public virtual Marca IdMarcaNavigation { get; set; } = null!;

    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
