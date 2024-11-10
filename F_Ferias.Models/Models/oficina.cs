using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models;
    public class oficina {

        public int  id { get; set; }
        public string  nombre_oficina { get; set; }
        public string  descripcion { get; set; }


        public int  id_entidad { get; set; } // CLAVE FORANEA
        public int  id_ubicacion { get; set; } // CLAVE FORANEA ESTE ELEMENTO SE DEJA MOMENTANEAMENTE SIN // CLAVE FORANEA



        public string  horario { get; set; }
        public string  correo_electronico { get; set; }
        public string  telefono { get; set; }



        public int? id_usuario_encargado { get; set; }

        public string encargado { get; set; }
        public int? user_create { get; set; }






        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }



        public string user_upddel { get; set; }
        public int estatus { get; set; }




        public string plataforma_utilizar { get; set; }
        public string identificador { get; set; }
        public int? tipo_espacio { get; set; }




        public DateTime fecha_ini { get; set; }
        public DateTime fecha_fin { get; set; }



        public int?  id_responsable { get; set; }
        public int?  id_consejero_asignado { get; set; }
        public int?  id_osne_encargada { get; set; }
        public bool? es_usne { get; set; }
        public string colonia_mostrar { get; set; }






        // CLAVES FORANEAS
        
    [ForeignKey("id_entidad ")]
    public virtual entidad Id_entidad_FK { get; set; }



    [ForeignKey("id_usuario_encargado ")]
    public virtual ApplicationUser Id_usuario_Encargado_FK { get; set; }

    [ForeignKey("id_consejero_asignado ")]
    public virtual ApplicationUser Id_usuario_consejero_Encargado_FK { get; set; }



    [ForeignKey("user_create ")]
    public virtual ApplicationUser Id_user_creo_FK { get; set; }

    
    }