using System;
using System.Collections.Generic;

namespace Service_Desk_IT.Models;

public partial class Administradore
{
    public int IdAdmin { get; set; }

    public int IdUsuario { get; set; }

    public int IdNivel { get; set; }

    public string? AreaResponsabilidadAdmin { get; set; }

    public virtual NivelesAcceso IdNivelNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
