using System;
using System.Collections.Generic;

namespace trabalhoAAD.Models;

public partial class Morada
{
    public int Id { get; set; }

    public string Numero { get; set; } = null!;

    public string Cp1 { get; set; } = null!;

    public string Cp2 { get; set; } = null!;

    public virtual ICollection<Atendente> Atendentes { get; set; } = new List<Atendente>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Fornecedor> Fornecedors { get; set; } = new List<Fornecedor>();

    public virtual ICollection<Mecanico> Mecanicos { get; set; } = new List<Mecanico>();
}
