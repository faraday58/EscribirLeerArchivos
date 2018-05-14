using System;
using ArchivosGestor;
namespace EscribirLeerArchivos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escribe tu contenido del archivo");
            string contenido = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de tu archivo");
            string nombre = Console.ReadLine();
            
            Archivo miarchivo = new Archivo(nombre, contenido);
            miarchivo.Escribir();
            miarchivo.Leer();
            Console.Write("Contenido del archivo: "+miarchivo.contenido+"\n");


        }
    }
}
