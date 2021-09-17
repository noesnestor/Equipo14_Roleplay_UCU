using System;
using System.Collections;

namespace Roleplay
{
    public class Personaje
    {
        public Personaje(string nombre, string raza, int salud)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Salud = salud;
            this.VidaMax = salud;
        }

        // Variables
        private ArrayList inventario = new ArrayList();
        private int ataque;
        private int defensa;

        // Propiedades
        public string Nombre {get; set;}
        public int Salud {get; private set;}
        public string Raza {get;}
        public int VidaMax {get;}

        /*
        Para obtener tanto el ataque como la defensa del personaje
        se decidio crear respectivamente sus propiedades en el personaje, ya que es el encargado
        de conocer el inventario, donde en el get de cada una
        se recorre todos los elementos que tiene creando asi el subtotal de valores necesarios
        para calcular tanto la defensa como el ataque total.
        */
        public int Ataque 
        {
            get
            {
                foreach (Elemento elemento in inventario)
                {
                  this.ataque += elemento.Ataque; 
                }
                return this.ataque;
            } 
        }

        public int Defensa 
        {
            get
            {
                foreach (Elemento elemento in inventario)
                {
                  this.defensa += elemento.Defensa;
                }
                return this.defensa;
            }
        }
        
        public void AgregarElemento(Elemento elemento)
        {
            if (this.Raza != "Mago" && elemento.Nombre == "Libro de Hechizos") 
            {
                Console.WriteLine("Solo los Magos pueden usar el Libro de Hechizos.");
            }
            else
            {
                this.inventario.Add(elemento);
            }
        }

        public void EliminarElemento(Elemento elemento)
        {
            if (this.inventario.Contains(elemento))
            {
                this.inventario.Remove(elemento);
                Console.WriteLine($"Le quitaste correctamente a {this.Nombre} el elemento {elemento.Nombre} del inventario.");
            }
            else
            {
                Console.WriteLine($"El elemento {elemento.Nombre} que querías quitarle a {this.Nombre} ya no estaba en su inventario.");
            }
        }

        /*
        El ataque se realiza a partir de un metodo Atacar,
        se le pasa por parametro otro personaje. Esto se decidio, ya que al atacar
        es necesario obtener los valores tanto de ataque como de defensa del objetivo y esta clase
        es la encargada de conocer estos valores.
        */
        public void Atacar(Personaje personaje)
        {
            int dmg = this.Ataque - personaje.Defensa;
            if (dmg<0)
            {
                Console.WriteLine($"¡El ataque de {this.Nombre} fue inútil debido a la defensa de {personaje.Nombre}!");
            } 
            else
            {
                if (dmg < personaje.Salud)
                {
                    personaje.Salud = personaje.Salud - dmg;
                    Console.WriteLine($"¡El ataque de {this.Nombre} logró dañar a {personaje.Nombre}! Le quedan {personaje.Salud} puntos de vida restantes!");
                }
                if (dmg >= personaje.Salud)
                {
                    personaje.Salud = 0;
                    Console.WriteLine($"¡El ataque de {this.Nombre} fue letal! Has vencido a {personaje.Nombre}!");
                }
            }
        }

        /*
        Dado que es el jugador quien tiene acceso a los valores de su salud,
        nos parecio que deberia tener la capacidad de curarse a si mismo, de esta forma
        poder cambiar sus atributos propios.
        */
        public void Curar(int vidaACurar)
        {
            if (this.Salud + vidaACurar > this.VidaMax)
            {
                this.Salud = this.VidaMax;
                Console.WriteLine($"Se ha curado por completo a {this.Nombre}, ahora tiene {this.Salud} de puntos de vida.");
            }
            else
            {              
                this.Salud += vidaACurar;
                Console.WriteLine($"Se ha curado a {this.Nombre}, ahora tiene {this.Salud} de puntos de vida.");
            }
        }
    }
}
