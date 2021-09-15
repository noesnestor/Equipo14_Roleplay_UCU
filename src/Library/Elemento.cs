using System;

namespace Roleplay
{
    public class Elemento
    {
        public string Nombre { get; }
        public int Ataque { get; }
        public int Defensa { get; }
        public string Tipo { get; }

        public Elemento(string nombre, int ataque, int defensa, string tipo)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Tipo = tipo;
        }
    }
}
