using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class abc_directorio {

        [Key]
        public  int id { get; set; }
        public  string fecha_actualizacion { get; set; }
        public  int consecutivo { get; set; }



        public  int id_entidad { get; set; }




        public  string entidad { get; set; }
        public  string tipo_oficina { get; set; }


        public  int id_oficina { get; set; }


        public  string accion { get; set; }
        public  int cdep_id { get; set; }
        public  string nom_oficina { get; set; }
        public  string oficina_historico { get; set; }
        public  string domicilio { get; set; }
        public  string t_asentamiento { get; set; }
        public  string colonia_mostrar { get; set; }
        public  string localidad { get; set; }
        public  string municipio { get; set; }
        public  string cp { get; set; }


        public  int id_municipio { get; set; }
        public  int id_codigopostal { get; set; }
        public  int id_colonia { get; set; }


        public  string colonia_correcta { get; set; }
        public  string verificar_colonia { get; set; }
        public  string entre_calleuno { get; set; }
        public  string entre_calledos { get; set; }
        public  string referencia { get; set; }
        public  string latitud { get; set; }
        public  string longitud { get; set; }
        public  string responsable { get; set; }
        public  string t_contacto { get; set; }
        public  string c_contacto { get; set; }
        public  string h_atencion { get; set; }
        public  string d_atencion { get; set; }
        public  bool vid_valida { get; set; }



        [ForeignKey("id_entidad")]
        public virtual entidad id_entidad_asociado_FK { get; set; }


        
        [ForeignKey("id_oficina ")]
        public virtual oficina id_oficina_asociado_FK { get; set; }
    }