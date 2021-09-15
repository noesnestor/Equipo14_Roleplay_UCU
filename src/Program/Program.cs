using System;
using System.Collections;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Elemento baston1 = new Elemento("Baston de Fuego", 70, 0, "Mago");
            Elemento tunica1 = new Elemento("Tunica de Mago", 0, 30, "Mago");
            Elemento libro = new Elemento("Libro de Hechizos", 0, 0, "Mago");

            Console.WriteLine(libro.Ataque);

            libro.AgregarHechizo("Dormir");

            Console.WriteLine(libro.Ataque);
        }
    }
}
