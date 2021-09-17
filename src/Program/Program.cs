using System;
using System.Collections;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Elemento baston1 = new Elemento("Baston de Fuego", 70, 0);
            Elemento tunica1 = new Elemento("Tunica de Mago", 0, 30);
            Elemento libro = new Elemento("Libro de Hechizos", 0, 0);
            Personaje Heroe = new Personaje("Messi","Enano",20);
            Personaje Villano = new Personaje("CR7","Mago",21);

            Console.WriteLine(libro.Ataque);

            libro.AgregarHechizo("Dormir");
            libro.AgregarHechizo("Pira");
            libro.AgregarHechizo("Piraga");

            Console.WriteLine(libro.Ataque);
            Villano.AgregarElemento(libro);
            Heroe.AgregarElemento(libro);
            Villano.Atacar(Heroe);
            Heroe.Curar(1);
        }
    }
}
