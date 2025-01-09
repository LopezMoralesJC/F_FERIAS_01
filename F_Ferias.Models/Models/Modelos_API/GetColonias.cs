using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models.Modelos_API;

  public class GetColonias {


    public class obtenerColonias {
    public  int IdEntidad  { get; set; }
    public  int IdMunicipio  { get; set; }
    }


    public class obtenercolonia_cp {
      public  string cp  { get; set; }
      public  string colonia  { get; set; }
      }
}
