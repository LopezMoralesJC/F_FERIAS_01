using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class cp_cepomex_mexico {

        
    [Key]
    public int Id  { get; set; }     
    public string d_codigo  { get; set; }
    public string d_asenta  { get; set; }
    public string d_tipo_asenta  { get; set; }
    public string D_mnpio  { get; set; }
    public string d_estado  { get; set; }
    public string d_ciudad  { get; set; }
    public int d_CP  { get; set; }            // STRING


    public int? id_entidad  { get; set; }

    public int c_estado  { get; set; }        // STRING
    public int c_oficina  { get; set; }       // STRING

    public string c_CP  { get; set; }

    public int c_tipo_asenta  { get; set; }   // STRING
    public int c_mnpio  { get; set; }         // STRING
    public int id_asenta_cpcons  { get; set; }    // STRING

    public string d_zona  { get; set; } 
    public int c_cve_ciudad  { get; set; } // STRING


    [ForeignKey("id_entidad")]
    public virtual entidad Id_entidad_FK { get; set; }

    }


