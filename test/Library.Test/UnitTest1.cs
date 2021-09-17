using NUnit.Framework;

namespace Roleplay
{
    [TestFixture]
    public class Test
    {
        /*
        La razón por la que se testea el valor ataque es porque es crucial para que
        funcione el metodo de clase "Atacar". Sin el, los personajes nunca serían capaces
        de hacerse daño debido a que ningún personaje tendría ataque para dañar.
        */
        
        [Test]
        public void TestAtaque()
        {
            Personaje Test1 = new Personaje("Muñeco de Testeo","Enano",1);
            Elemento Arma1 = new Elemento("Espada",20,0);
            Test1.AgregarElemento(Arma1);
            int expected = 20;
            Assert.AreEqual(expected,Test1.Ataque);
        }   

        /*
        La razón por la que se testea el valor de agregar un hechizo es porque es crucial para que
        funcione el ataque del libro. Si esto no funciona, el libro tendra un ataque que no corresponde
        a la cantidad de hechizos.
        */
        [Test]
        public void TestAgregarHechizo()
        {
            Elemento libro = new Elemento("Libro de Hechizos", 0, 0);
            libro.AgregarHechizo("Hechizo de Testeo 1");
            libro.AgregarHechizo("Hechizo de Testeo 2");
            
            int expected = 2;
            Assert.AreEqual(expected, libro.Ataque);
        }
    }
}