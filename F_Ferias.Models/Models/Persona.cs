using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models;
    public class Persona {
        public int  id { get; set; }
        public string  nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int entidad_nacimiento { get; set; }
        public int nacionalidad { get; set; }
        public string genero { get; set; }
        public string correo_electronico { get; set; }
        public string curp { get; set; }
        public string tipo_telefono { get; set; }
        public string telefono { get; set; }


        public int? id_ubicacion { get; set; } // Rdte campo esta sin datos pero permanece
        public int id_usuario { get; set; }
        public int? id_tipodiscapacidad { get; set; }


        public bool atencion_preferente { get; set; }
        public int atencion_preferencial { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool acepto_terminos { get; set; }
        public bool datos_correctos { get; set; }
        public bool acepto_arco { get; set; }
        public bool acepto_ofertas { get; set; }
        public bool contacto_portal { get; set; }
        public bool contacto_telefonico { get; set; }
        public bool contacto_correo { get; set; }
        public int  estatus { get; set; }
        public int  siisne_tipo_persona { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool contactar_portal { get; set; }
        public string siine_tipo_persona { get; set; }
        public string  correo_electronico_inhabilitado { get; set; }
        public string  curp_inhabilitado { get; set; }
        public string  user_create { get; set; }
        public string  user_upddel { get; set; }
        public string  motivo_inhabilitacion { get; set; }
        public int  estatus_pcm { get; set; }
        public string  pcm_whatsapp { get; set; }
        public int  pcm_entidad_reside { get; set; }
        public int  pcm_municipio_reside { get; set; }
        public bool pcm_necesita_visa_trabajar  { get; set; }
        public string  id_pais_lada_telefono { get; set; }
        public string  id_pais_lada_whatsapp { get; set; }
        public byte foto { get; set; }
        public string  archivo_foto { get; set; }



        // Claves Foraneas

        [ForeignKey("id_usuario ")]
        public virtual ApplicationUser usuario_Inserto_FK { get; set; }

        [ForeignKey("id_tipodiscapacidad ")]
        public virtual tipodiscapacidad Id_tipo_discapacidado_FK { get; set; }

        

    }