using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models;
    public class bitacora_evento {
        
    [Key]
    public int id { get; set; }


    public int accion { get; set; }
    public int id_modulo { get; set; }
    public int id_usuario { get; set; }
    public int id_propietario { get; set; }



    public DateTime fecha_reg { get; set; }
    public DateTime hora_reg { get; set; }

     [Column(TypeName = "jsonb")]
    public string datos { get; set; }







  // CLAVES FORANEAS 
    [ForeignKey("accion")]
    public virtual accion_por_modulo id_accion_por_modulo_FK { get; set; }

    [ForeignKey("id_modulo")]
    public virtual modulo Id_aplicativo_FK { get; set; }

    [ForeignKey("id_usuario")]
    public virtual ApplicationUser Id_usuario_Inserto_FK { get; set; }

    [ForeignKey("id_propietario")]
    public virtual tipo_propietario Id_tipo_propietario_FK { get; set; }
    }