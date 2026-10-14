namespace Ucu.Poo.Excercise
{
    public static class GarageGate
    {
        public static bool CalcularApertura(bool entradaA, bool entradaB, bool entradaC)
        {
            return Circuito.Calcular(entradaA, entradaB, entradaC);
        }
    }
}