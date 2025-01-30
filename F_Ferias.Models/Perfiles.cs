using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;
using F_Ferias.Models.Models;

namespace F_Ferias.Models ;
    public class Perfiles {


    [Key]
    public int Id  { get; set; }

    public string nombre_rol { get; set; }
    public string descripcion { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime created_at { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime updated_at { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime deleted_at { get; set; } 
    
     public int estatus { get; set; }

    
    public int? user_created  { get; set; }


    [ForeignKey("user_created")]
    public virtual Estatus estatus_actual { get; set; }

    
    [ForeignKey("user_create")]
    public virtual ApplicationUser usuario_Inserto { get; set; }
    }
