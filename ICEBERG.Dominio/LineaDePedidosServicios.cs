using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio
{
    public class LineaDePedidosServicios
    {
        private IcebergDbContext IcebergDbContext;

        public LineaDePedidosServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }
        public List<Object> ListadoLineasDePedido()
        {
            var listado = (from articulo in IcebergDbContext.Articulos
                           join categoría in IcebergDbContext.Categorías on articulo.Categoría.CategoríaId equals categoría.CategoríaId
                           join rubro in IcebergDbContext.Rubros on articulo.Categoría.Rubro.RubroId equals rubro.RubroId
                           where articulo.Estado == false
                           select new
                           {
                               ArticuloId = articulo.ArticuloId,
                               Codigo = articulo.Codigo,
                               Descripción = articulo.Descripción,
                               PrecioCosto = articulo.PrecioCosto,
                               PrecioPedidoPorMenor = articulo.PrecioPedidoPorMenor,
                               PrecioPedidoPorMayor = articulo.PrecioPedidoPorMayor,
                               Categoria = categoría.Descripción,
                               Rubro = rubro.Descripción
                           });
            return listado.ToList<Object>();
        }
    }
}
