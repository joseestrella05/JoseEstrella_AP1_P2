using System.ComponentModel.DataAnnotations;

namespace JoseEstrella_AP1_p2.Models;

public class Combos
{
    [Key]
    public int ComboId { get; set; }

    public DateTime Fecha { get; set; } = DateTime.Now;

    public string Descripcion { get; set; }

    public double Precio { get; set; }

    public int vendido {  get; set; }



}
