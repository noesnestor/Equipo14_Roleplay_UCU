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
        /*
        Es importante testear el valor defenda porque es necesario para que los ataques de los 
        enemigos tengan alguan resistencia antes de afectar la vida del contrincante
        */
        [Test]
        public void TestDefensa()
        {
            Personaje Test2 = new Personaje("Tester","Elfo",20);
            Elemento Escudo = new Elemento("Escudo",0,50);
            Test2.AgregarElemento(Escudo);
            int expected = 50;
            Assert.AreEqual(expected,Test2.Defensa);
        }
        [Test]
        public void TestAtaqueAPersonaje()
        {
            Personaje pj1 = new Personaje("Test 1", "Elfo", 10);
            Personaje pj2 = new Personaje("Test 2", "Enano", 20);

            Elemento espada = new Elemento("Espada", 20, 0);
            Elemento escudo = new Elemento("Escudo", 0, 10);

            pj1.AgregarElemento(espada);
            pj2.AgregarElemento(escudo);

            pj1.Atacar(pj2);

            int expected = 10;

            Assert.AreEqual(expected, pj2.Salud);
        }


        /*
        Es importante testear el metodo curar ya que de no funcionar, los personajes no podrian regenerar vida.
        */
        [Test]
        public void TestCurar()
        {
            Personaje Test3 = new Personaje("Tester","Elfo",50);
            Personaje Test4 = new Personaje("Tester2", "Elfo", 50);
            Elemento Test5 = new Elemento("Ataque_Test",20, 0);
            Test4.AgregarElemento(Test5);
            Test4.Atacar(Test3);
            Test3.Curar(5);
            int expected = 35;
            Assert.AreEqual(expected, Test3.Salud);
        }
    }
}