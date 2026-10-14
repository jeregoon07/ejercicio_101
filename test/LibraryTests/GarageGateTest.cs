using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Execution;
using Ucu.Poo.Excercise;
namespace Ucu.Poo.Excercise.Tests
{
    [TestFixture]
    public class GarageGateTest
    {
        [Test]
        public void Apertura()
        {
            bool entradaA=false;
            bool entradaB=false;
            bool entradaC=true;
            bool resultadoFinal=GarageGate.CalcularApertura(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"la puerta se abrio?| {resultadoFinal}");
            Assert.That(resultadoFinal, Is.True);
        }
        [Test]
        public void Apertura1()
        {
            bool entradaA=true;
            bool entradaB=true;
            bool entradaC=true;
            bool resultadoFinal=GarageGate.CalcularApertura(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"la puerta se abrio?| {resultadoFinal}");
            Assert.That(resultadoFinal, Is.True);
        }
        [Test]
        public void NoApertura()
        {
            bool entradaA=false;
            bool entradaB=true;
            bool entradaC=true;
            bool resultadoFinal=GarageGate.CalcularApertura(entradaA,entradaB,entradaC);
            TestContext.WriteLine($"la puerta se abrio?| {resultadoFinal}");
            Assert.That(resultadoFinal, Is.False);
        }
        [Test]
        public void NoApertura2()
        {
            bool entradaA=true;
            bool entradaB=true;
            bool entradaC=false;
            bool resultadoFinal=GarageGate.CalcularApertura(entradaA, entradaB, entradaC);
            TestContext.WriteLine($"la puerta se abrio| {resultadoFinal}");
            Assert.That(resultadoFinal, Is.False);
        }
    }
}