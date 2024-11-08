using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models; 
    public class ferias_nacional {
        
        [Key]
        public int id { get; set; }	

        // [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ingresa un nombre para cargo")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Nombre de la feria*")]
        public string nombre  { get; set; }

       [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
       [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       [DataType(DataType.Date)]
        public DateTime fecha_inicio { get; set; }

       [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de Fin*:")]
       [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       [DataType(DataType.Date)]
        public DateTime fecha_fin  { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "Hora Inicio*:")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Time)]
        public DateTime hora_inicio	{ get; set; }   // Se insertara la hora 

        [System.ComponentModel.DataAnnotations.Display(Name = "Hora Fin*:")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Time)]
        public DateTime hora_fin { get; set; }  // Se insertara la hora 
        public Byte feria_logo { get; set; } // Se insertara una imagen BLOB para almacenar en base
        public int estatus { get; set; }
        public bool entidades_todas	 { get; set; }

        [Column(TypeName = "jsonb")]
        public string Dataentidades_selection { get; set; }

       [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       [DataType(DataType.Date)]
        public DateTime create_at { get; set; }

       [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       [DataType(DataType.Date)]
        public DateTime update_at { get; set; }
        public  int user_create	 { get; set; }
        public int? user_upddel { get; set; }





        // CLAVES FORANEAS

        [ForeignKey("user_create")]
        public virtual ApplicationUser Id_usuario_Inserto_FK { get; set; }

       [ForeignKey("user_upddel")]
        public virtual ApplicationUser Id_usuario_Actualizo_FK { get; set; }

        [ForeignKey("estatus")]
        public virtual ferias_estatus Id_FKestatus_feria_FK { get; set; }
    }
