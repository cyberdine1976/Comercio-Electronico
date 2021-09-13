using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class ProductoDTO
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Categoria { get; set; }
        public Nullable<decimal> Precio { get; set; }

    }
}
