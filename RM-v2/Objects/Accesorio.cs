using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM_v2.Objects
{
    public class Accesorio
    {
        public int AccesorioId { get; set; }
        public string? _codigo;
        public string Codigo { get => _codigo; set => _codigo = value.ToUpper(); }
        public string? Nombre { get; set; }
        public int CantidadSuelta { get; set; }
        public int CantidadBolsas { get; set; }
        public string? Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set;}
    }
}
