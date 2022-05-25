using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Datos
{
    public class Acceso
    {
        private string ArchivoDatos;

        public Acceso(string Archivo)
        {
            this.ArchivoDatos = Archivo;
            if (!File.Exists(this.ArchivoDatos))
            {
                //Si no existe el archivo lo crea
                FileStream fs = File.Create(this.ArchivoDatos);
                fs.Close();
            }
        }
        public string Leer()
        {
            //Se abre el archio y se lee el contenido del mismo
            string s = string.Empty;
            using (StreamReader sr = File.OpenText(this.ArchivoDatos))
            {
                s = sr.ReadLine();
            }
            return s;
        }
        public void Guardar(string Valores)
        {
            //Borro el archivo anterior
            if (File.Exists(this.ArchivoDatos))
            {
                File.Delete(this.ArchivoDatos);
            }
            //Creo el nuevo archivo con el contenido actualizado
            using(FileStream fs = File.Create(this.ArchivoDatos))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(Valores);
                fs.Write(info, 0, info.Length);
            }
        }
        public void Eliminar(string NombreArchivo)
        {
            File.Delete(this.ArchivoDatos);
        }
    }
}
