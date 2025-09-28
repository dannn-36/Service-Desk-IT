using System;
using System.Collections.Generic;

namespace Service_Desk_IT.Models;

public partial class Sesione
{
    public int IdSesion { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? FechaHoraInicioSesion { get; set; }

    public DateTime? FechaHoraFinSesion { get; set; }

    public bool? SesionActiva { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
