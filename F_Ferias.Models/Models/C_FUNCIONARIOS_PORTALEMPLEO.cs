using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models;
    public class C_FUNCIONARIOS_PORTALEMPLEO {
        
        [Key]
        public int CEDO_ID  { get; set; }
        public int id_entidad  { get; set; }
        public string  ESTADO  { get; set; }
        public string DEPENDENCIA  { get; set; }
        public int? ID  { get; set; }
        public string NOMBRE  { get; set; }
        public string APELLIDOP  { get; set; }
        public string APELLIDOM  { get; set; }
        public string CARGO  { get; set; }
        public string PUESTO  { get; set; }
        public string RECURSO  { get; set; }
        public string EMAIL  { get; set; }
        public string TELEFONO  { get; set; }
        public string TITULO  { get; set; }
        public string CURP  { get; set; }
        public string TIPO  { get; set; }
        public string AREA  { get; set; }
        public string TELEFONO_OSNE  { get; set; }
        public int? id_oficina  { get; set; }
        public int id_usuario  { get; set; }


        // Claves foraneas 
        [ForeignKey("id_usuario")]
        public virtual ApplicationUser usuario_Inserto { get; set; }

        [ForeignKey("id_oficina")]
        public virtual oficina Id_Oficina_FK { get; set; }

       [ForeignKey("id_entidad")]
        public virtual entidad Id_entidad_FK { get; set; }         
        
    }