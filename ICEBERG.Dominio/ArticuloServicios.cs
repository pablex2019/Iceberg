using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio
{
    public class ArticuloServicios
    {
        private IcebergDbContext IcebergDbContext;

        public ArticuloServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }
        public void ABMArticulo(Articulo articulo, int operacion, int id)
        {
            var _articulo = id == 0 ? null : IcebergDbContext.Articulos.Where(x => x.ArticuloId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Articulos.Add(articulo);
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
                case 2:
                    try
                    {
                        _articulo.Codigo = Convert.ToInt32(articulo.Codigo);
                        _articulo.Descripción = articulo.Descripción;
                        _articulo.PrecioCosto = articulo.PrecioCosto;
                        _articulo.PrecioPedidoPorMenor = articulo.PrecioPedidoPorMenor;
                        _articulo.PrecioPedidoPorMayor = articulo.PrecioPedidoPorMayor;
                        _articulo.FechaHora = DateTime.Now;
                        _articulo.Estado = false;
                        _articulo.Categoría = articulo.Categoría;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
                case 3:
                    try
                    {
                        _articulo.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Object> ListadoArticulos()
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

        public Articulo ObtenerArticulo(int Id)
        {
            Articulo arti = new Articulo();

            var listado = (from articulo in IcebergDbContext.Articulos
                           join categoría in IcebergDbContext.Categorías on articulo.Categoría.CategoríaId equals categoría.CategoríaId
                           join rubro in IcebergDbContext.Rubros on articulo.Categoría.Rubro.RubroId equals rubro.RubroId
                           where categoría.CategoríaId == Id
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

            arti.ArticuloId = listado.ToList().First().ArticuloId;
            arti.Codigo = listado.ToList().First().Codigo;
            arti.Descripción = listado.ToList().First().Descripción;
            arti.PrecioCosto = listado.ToList().First().PrecioCosto;
            arti.PrecioPedidoPorMenor = listado.ToList().First().PrecioPedidoPorMenor;
            arti.PrecioPedidoPorMayor = listado.ToList().First().PrecioPedidoPorMayor;
            arti.Categoría = ObtenerCategoríaDelArticulo(listado.ToList().First().Categoria);
            return arti;
        }
        public Categoría ObtenerCategoríaDelArticulo(string nombre)
        {
            return IcebergDbContext.Categorías.Where(x => x.Descripción == nombre).First();
        }
        public List<string> ObtenerCategorias()
        {
            return IcebergDbContext.Categorías.Where(x => x.Estado == false).Select(x => x.Descripción).ToList();
        }
    }
}
