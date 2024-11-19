using System.ComponentModel.DataAnnotations;

namespace JoseEstrella_AP1_p2.Models;

public class ComboDestalle
{
    [Key]
    public int DestalleId { get; set; }

    public int ArticuloId { get; set; }

    public int Cantidad { get; set; }

    public double Costo { get; set; }

    public int Vendido { get; set; }

    
}
