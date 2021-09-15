using System;
using System.Collections;

namespace Roleplay
{
    public class Elemento
    {
        // Variables.
        private ArrayList hechizos = new ArrayList(); // Array que contiene los hechizos.
        private int ataque;

        // Propiedades.
        public string Nombre { get; }
        public int Ataque 
        { 
            get
            {
                // Si el elemento es el Libro de Hechizos.
                if (this.Nombre == "Libro de Hechizos")
                {
                    return hechizos.Count; // Retorna la cantidad de hechizos como ataque.
                }
                else
                {
                    return this.ataque;
                }
            }
            private set
            {
                this.ataque = value;
            }
        }
        public int Defensa { get; }
        public string Raza { get; }

        public Elemento(string nombre, int ataque, int defensa, string raza)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Raza = raza;
        }


        // Metodo para agregar hechizo al libro de hechizos.
        public void AgregarHechizo(string hechizo)
        {
            hechizos.Add(hechizo);
        }
    }
}
