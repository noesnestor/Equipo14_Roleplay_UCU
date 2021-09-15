using System;

namespace Roleplay
{
    public class Elemento
    {
        public string Nombre { get; }
        public int Ataque { get; }
        public int Defensa { get; }
        public string Raza { get; }

        public Elemento(string nombre, int ataque, int defensa, string raza)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Raza = raza;
        }
    }
}
