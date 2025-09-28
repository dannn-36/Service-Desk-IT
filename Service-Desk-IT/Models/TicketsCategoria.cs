using System;
using System.Collections.Generic;

namespace Service_Desk_IT.Models;

public partial class TicketsCategoria
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
