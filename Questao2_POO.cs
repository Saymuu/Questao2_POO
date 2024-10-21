using System;

class Programa
{
    static void Main(string[] args)
    {
        Montador montador = new Montador();

        montador.MontarVentilador();

        Console.WriteLine("Pilha original:");
        montador.ExibirPilha();

        Console.WriteLine("\nSubstituindo a peça 'Hélice' por 'Hélice Nova'...");
        montador.SubstituirPeca("Hélice Quebrada", "Hélice Nova");

        Console.WriteLine("\nPilha após a substituição:");
        montador.ExibirPilha();
    }
}
