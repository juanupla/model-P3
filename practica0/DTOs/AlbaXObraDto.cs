namespace practica0.DTOs;

   
public class AlbaXObraDto   
{
    public Guid IdAlbanil { get; set; }

    public Guid IdObra { get; set; }

    public string TareaArealizar { get; set; } = null!;

    public DateTime? FechaAlta { get; set; }
}

