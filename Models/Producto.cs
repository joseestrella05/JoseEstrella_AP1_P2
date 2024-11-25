using System.ComponentModel.DataAnnotations;

namespace JoseEstrella_AP1_p2.Models;

public class Producto
{
    [Key]
    public int ProductoId { get; set; }

    public int Existencia { get; set; }

    public string Descripcion { get; set; }

    public double Precio { get; set; }

    public double Costo { get; set; }
}
