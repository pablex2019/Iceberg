using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Dominio;
using ICEBERG.Datos;

namespace ICEBERG.Aplicación
{
    public class RubroServicios
    {
        private IcebergDbContext IcebergDbContext;

        public RubroServicios()
        {
            IcebergDbContext = new IcebergDbContext();
        }

        public void ABMRubro(Rubro rubro, int operacion, int id)
        {
            var _rubro = id == 0 ? null : IcebergDbContext.Rubros.Where(x => x.RubroId == id).First();
            switch (operacion)
            {
                case 1:
                    try
                    {
                        IcebergDbContext.Rubros.Add(rubro);
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
                        _rubro.Descripción = rubro.Descripción;
                        _rubro.Estado = false;
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
                        _rubro.Estado = true;
                        IcebergDbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    break;
            }
        }

        public List<Rubro> ListadoRubros()
        {
            return IcebergDbContext.Rubros.Where(x=>x.Estado == false).ToList();
        }

        public Rubro ObtenerRubro(int Id)
        {
            return IcebergDbContext.Rubros.Where(x => x.RubroId == Id).First();
        }
    }
}
