﻿namespace practica0.DTOs;

public class AlbanileDto
{
    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Telefono { get; set; }

    public string Calle { get; set; }

    public string Numero { get; set; }

    public string CodPost { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaAlta { get; set; }
}

