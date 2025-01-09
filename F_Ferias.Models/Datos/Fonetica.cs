using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Ferias.Utilities.Datos;

public static class Fonetica 
{
//    public static string EliminarTildes(string texto)
//     {
//         return texto.Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ú', 'u');
//     }



//     public static string SustitucionSimple(string palabra)
//     {
//         return (palabra.Replace('ñ', 'n').Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').
//                         Replace('ó', 'o').Replace('ú', 'u').Replace('ü', 'u').
//                         Replace("aa", "a").Replace("ee", "e").
//                         Replace("ii", "i").Replace("oo", "o").Replace("uu", "u").Replace("ge", "je").Replace("ce", "se"));
//     }

        
       public  static string RemoveDiacritics(string stIn) {
        string stFormD = stIn.Normalize(NormalizationForm.FormD);
        StringBuilder sb = new StringBuilder();

        for(int ich = 0; ich < stFormD.Length; ich++) {
            UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
            if(uc != UnicodeCategory.NonSpacingMark) {
                sb.Append(stFormD[ich]);
            }
        }

        return(sb.ToString().Normalize(NormalizationForm.FormC));
    }    


    
}