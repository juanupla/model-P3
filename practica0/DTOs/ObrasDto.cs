using practica0.Model;

namespace practica0.DTOs;

public class ObrasDto
{
    public Guid Id { get; set; }

    public string Nombre { get; set; }

    public string DatosVarios { get; set; }

    public int cantAlba { get; set; }

    public  TiposObraDto IdTipoObraNavigation { get; set; }
}

