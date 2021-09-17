using System;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Elemento baston1 = new Elemento("Baston de Fuego", 70, 0);
            Elemento tunica1 = new Elemento("Tunica de Mago", 0, 30);
            Elemento espada1 = new Elemento("Espada de la Trifuerza", 100,0);
            Elemento escudo1 = new Elemento("Escudo", 0, 100);
            Elemento libro = new Elemento("Libro de Hechizos", 0, 0);
            Elemento hacha = new Elemento("Hacha de vikingo",80,0);
            Elemento pechera = new Elemento("Pechera de plata",0,50);
            Personaje Heroe = new Personaje("Messi","Enano",20);
            Personaje Villano = new Personaje("CR7","Mago",21);
            Personaje mago1 = new Personaje("Gandalf", "Mago", 100);
            Personaje elfo = new Personaje("Link", "Elfo", 50);     
            Personaje Juan = new Personaje("Juan","Enano",80);

            Console.WriteLine(libro.Ataque);

            libro.AgregarHechizo("Dormir");
            libro.AgregarHechizo("Pira");
            libro.AgregarHechizo("Piraga");

            Console.WriteLine(libro.Ataque);
            Juan.AgregarElemento(pechera);
            Juan.AgregarElemento(hacha);
            Villano.AgregarElemento(libro);
            Heroe.AgregarElemento(libro);
            Villano.Atacar(Heroe);
            Heroe.Curar(1);
        }
    }
}
