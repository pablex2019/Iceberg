using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Objetos;
using ICEBERG.Datos;

namespace ICEBERG.Dominio
{
    public class CategoríaServicios
    {
        private IcebergDbContext IcebergDbContext;

        public CategoríaServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }

        public void ABMCategoría(Categoría categoría, int operacion, int id)
        {
            var _categoría = id == 0 ? null : IcebergDbContext.Categorías.Where(x => x.CategoríaId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Categorías.Add(categoría);
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
                        _categoría.Descripción = categoría.Descripción;
                        _categoría.Estado = false;
                        _categoría.Rubro = categoría.Rubro;
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
                        _categoría.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Object> ListadoCategorías()
        {
            var listado = (from categoria in IcebergDbContext.Categorías
                           join rubro in IcebergDbContext.Rubros on categoria.Rubro.RubroId equals rubro.RubroId
                           where categoria.Estado == false
                           select new
                           {
                               categoria.CategoríaId,
                               categoria.Descripción,
                               Rubro = rubro.Descripción
                           });
            return listado.ToList<Object>();
        }

        public Categoría ObtenerCategoría(int Id)
        {
            Categoría categoría = new Categoría();

            var listado = (from categoria in IcebergDbContext.Categorías
                           join rubro in IcebergDbContext.Rubros on categoria.Rubro.RubroId equals rubro.RubroId
                           where categoria.CategoríaId == Id
                           select new
                           {
                               categoria.CategoríaId,
                               categoria.Descripción,
                               Rubro = rubro.Descripción
                           });

            categoría.CategoríaId = listado.ToList().First().CategoríaId;
            categoría.Descripción = listado.ToList().First().Descripción;
            categoría.Rubro = ObtenerRubroDeLaCategoría(listado.ToList().First().Rubro);

            return categoría;
        }
        public Rubro ObtenerRubroDeLaCategoría(string nombre)
        {
            return IcebergDbContext.Rubros.Where(x => x.Descripción == nombre).First();
        }
    }
}
