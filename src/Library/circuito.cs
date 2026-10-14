namespace Ucu.Poo.Excercise
{
    public static class Circuito
    {
        public static bool Calcular(bool entradaA, bool entradaB, bool entradaC)
        {
            bool cableAnd = entradaA && entradaB;
            bool cableNot = !entradaA && !entradaB;
            bool cableOr = cableAnd || cableNot;
            return cableOr && entradaC;
        }
    }
}