using System.ComponentModel.DataAnnotations;

namespace JoseEstrella_AP1_p2.Models;

public class Registro
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    public string Name { get; set; }

}
