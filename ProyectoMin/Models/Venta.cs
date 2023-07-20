using System;
using System.Collections.Generic;

namespace ProyectoMin.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public DateTime? FechaVenta { get; set; }

    public int? IdCliente { get; set; }

    public virtual ICollection<DetallesVenta> DetallesVenta { get; set; } = new List<DetallesVenta>();

    public virtual Cliente? IdClienteNavigation { get; set; }
}
