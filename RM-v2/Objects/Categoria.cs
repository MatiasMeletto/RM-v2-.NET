using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_v2.Objects
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nombre { get; set; }

        public List<Accesorio> Accesorios { get; set;} = new List<Accesorio>();
    }
}
