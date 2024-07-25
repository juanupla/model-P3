﻿using System;
using System.Collections.Generic;

namespace practica0.Model;

public partial class Deporte
{
    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime FechaAlta { get; set; }

    public virtual ICollection<Socio> Socios { get; set; } = new List<Socio>();
}
