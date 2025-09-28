using System;
using System.Collections.Generic;

namespace Service_Desk_IT.Models;

public partial class Supervisore
{
    public int IdSupervisor { get; set; }

    public int IdUsuario { get; set; }

    public int IdNivel { get; set; }

    public string? AreaResponsabilidadSupervisor { get; set; }

    public virtual NivelesAcceso IdNivelNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
