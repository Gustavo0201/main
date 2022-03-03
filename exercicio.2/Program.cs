using System;

namespace exercicio._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor em U$: ");
            string valor = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 5.22m;

            decimal.TryParse(valor, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido / valorCambio;

            Console.WriteLine($"Valor convertido:  {valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
