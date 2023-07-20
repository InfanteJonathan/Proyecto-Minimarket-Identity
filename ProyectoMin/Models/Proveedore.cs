using System;
using System.Collections.Generic;

namespace ProyectoMin.Models;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
