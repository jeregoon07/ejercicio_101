using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Execution;
using Ucu.Poo.Excercise;
namespace Ucu.Poo.Excercise.Tests
{
    [TestFixture]
    public class CircuitoTest
    {
        [Test]
        public void Calculo_de_todo()
        {
            bool entradaA = false;
            bool entradaB = false;
            bool entradaC = false;
            bool resultadoFinal= Circuito.Calcular(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal,Is.False);
        }
        [Test]
        public void Calcular_de_todo()
        {
            bool entradaA= true;
            bool entradaB=false;
            bool entradaC=false;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal, Is.False);
        }
        [Test]
        public void Calcular_de_todo1()
        {
            bool entradaA= false;
            bool entradaB=true;
            bool entradaC=false;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal, Is.False);
        }
        [Test]
        public void Calcular_de_todo2()
        {
            bool entradaA=false;
            bool entradaB=true;
            bool entradaC=false;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal, Is.False);
        }
        [Test]
        public void Calcular_de_todo3()
        {
            bool entradaA= true;
            bool entradaB= true;
            bool entradaC= false;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal,Is.False);
        }
        [Test]
        public void Calcular_de_todo4()
        {
            bool entradaA=false;
            bool entradaB=false;
            bool entradaC=true;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB,entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal,Is.True);
        }
        [Test]
        public void Calcular_de_todo5()
        {
            bool entradaA= true;
            bool entradaB= false;
            bool entradaC= true;
            bool resultadoFinal=Circuito.Calcular(entradaA,entradaB,entradaC);
            TestContext.WriteLine($"el resultado de la prueba es {resultadoFinal}");
            Assert.That(resultadoFinal,Is.False);
        }
        [Test]
        public void Calcular_de_todo6()
        {
            bool entradaA=false;
            bool entradaB=true;
            bool entradaC=true;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB,entradaC);
            TestContext.WriteLine($"el resultado final de todo es {resultadoFinal}");
            Assert.That(resultadoFinal,Is.False);
        }
        [Test]
        public void Calcular_de_todo7()
        {
            bool entradaA=true;
            bool entradaB=true;
            bool entradaC=true;
            bool resultadoFinal=Circuito.Calcular(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"el resultado final de todo es {resultadoFinal}");
            Assert.That(resultadoFinal,Is.True);
        }
    }
    
}