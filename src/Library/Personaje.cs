using System;
using System.Collections;
using System.Text;
using System.Runtime;

namespace Roleplay
{
    public class Personaje
    {
        private ArrayList inventario = new ArrayList();

        public Personaje(string nombre, string raza, int salud)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Salud = salud;
            this.VidaMax = salud;
        }

        private string nombre;
        private string raza;
        private int salud;

        public string Nombre {get; set;}
        public int Salud {get; private set;}
        public string Raza {get;}
        public int VidaMax {get;}
        
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

        public void Atacar(Personaje personaje, Elemento elemento)
        {
            int contador = 0;
            foreach (Elemento elementoAlmacenado in this.inventario)
            {
                if (elementoAlmacenado.Nombre == elemento.Nombre)
                {
                    int dmg = elementoAlmacenado.Ataque - elemento.Ataque;
                    if (dmg<0)
                    {
                        Console.WriteLine($"¡El ataque de {this.Nombre} con {elemento.Nombre} fue inútil debido a la defensa de {personaje.Nombre}!");
                    } 
                    else
                    {
                        if (dmg < personaje.Salud)
                        {
                            personaje.Salud = personaje.Salud - dmg;
                            Console.WriteLine($"¡El ataque de {this.Nombre} con {elemento.Nombre} logró dañar a{personaje.Nombre}! Le quedan {personaje.Salud} puntos de vida restantes!");
                        }
                        if (dmg >= personaje.Salud)
                        {
                            personaje.Salud = 0;
                            Console.WriteLine($"¡El ataque de {this.Nombre} con {elemento.Nombre} fue letal! Has vencido a {personaje.Nombre}!");
                        }
                    }

                }
                else
                {
                    contador +=1;
                }
                
            }
            if (contador == inventario.Count)
            {
                Console.WriteLine("El personaje no posee el item que especificas.");
            }
        }   


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
