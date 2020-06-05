using System;

namespace Polimorfismo_overload_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();
            System.Console.WriteLine(infoPlayer.Calcular());
            System.Console.WriteLine( infoPlayer.Calcular(100));
            System.Console.WriteLine(infoPlayer.Calcular(100, 40));
            System.Console.WriteLine(infoPlayer.Calcular("Bruce","Banner"));
        }
    }
}
