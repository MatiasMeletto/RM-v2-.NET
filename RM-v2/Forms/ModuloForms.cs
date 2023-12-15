using Newtonsoft.Json;
using RM_v2.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_v2.Forms
{
    public class ModuloForms
    {
        public static void EscribirLista(List<Accesorio> accesorios)
        {
            using (StreamWriter streamWriter = new StreamWriter("accesorios.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(accesorios));
            }
        }
        public static List<Accesorio> LeerArchivo()
        {
            FileInfo fi = new FileInfo("accesorios.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("accesorios.json"))
                {
                    return JsonConvert.DeserializeObject<List<Accesorio>>(sr.ReadToEnd());
                }
            }
            List<Accesorio> lista = new List<Accesorio>();
            return lista;
        }
        public static List<string> ValidarDatos(string codigo, string nombre, string descripcion, decimal bolsas, decimal sueltos)
        {
            List<string> Errores = new List<string>();

            if (string.IsNullOrEmpty(codigo))
                Errores.Add("Debe ingresar codigo");

            if (string.IsNullOrEmpty(nombre))
                Errores.Add("Debe ingresar un nombre");

            if (bolsas == 0 && sueltos == 0)
                Errores.Add("Debe ingresar al menos una cantidad");

            if (string.IsNullOrEmpty(descripcion))
                Errores.Add("Debe ingresar descripcion");

            return Errores;
        }
    }
}
