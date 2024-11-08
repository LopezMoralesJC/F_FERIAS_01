using System.ComponentModel.DataAnnotations;

namespace F_Ferias.Models.Models;

public class ferias_estatus {

    [Key]
    public int Id { get; set; }
    public string  Idescripcion { get; set; }
    public string  estatus { get; set; }
}