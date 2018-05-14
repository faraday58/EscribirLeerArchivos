using System;
using System.IO;

namespace ArchivosGestor
{
    public class Archivo
    {
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;

        private string nombre;
        public string contenido;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if(value =="")
                {
                    nombre = "archivo.txt";
                }
                else
                {
                    nombre = value;
                }
            }
        }

        /// <summary>
        /// Constructor que pide el nombre del archivo y su 
        /// contenido en formato de cadena. Texto plano
        /// </summary>
        /// <param name="Nombre">Ruta del archivo y su identificador</param>
        /// <param name="contenido">Es lo que desea almacenar el usuario</param>

        public Archivo(string Nombre,string contenido  )
        {
            this.contenido = contenido;
            this.Nombre = Nombre;
        }


        public void Escribir()
        {
            try
            {
                sw = new StreamWriter(Nombre);
                sw.WriteLine(contenido);
            }            
            catch(IOException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                sw.Close();
            }

        }

        public void EscribirAppend( )
        {
            try
            {
                fs = new FileStream(Nombre, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(contenido);
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                sw.Close();
            }

        }
        public void LeerAppend()
        {

            try
            {
                sr = new StreamReader(fs);
                contenido = sr.ReadLine();
                while ( contenido != null  )
                {
                    contenido += contenido;
                }
                

            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                sr.Close();
            }

        }



        public void Leer()
        {
            
            try
            {
                sr = new StreamReader(Nombre);
                contenido = sr.ReadLine();
                
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                sr.Close();
            }

        }

    }
}
