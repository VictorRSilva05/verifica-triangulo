using System;
using System.Security.Principal;

namespace verifica_triangulo;

//Victor Rafael da Silva
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            int ladoX = LerLado("X");
            int ladoY = LerLado("Y");
            int ladoZ = LerLado("Z");

            ExibirValoresInformados(ladoX, ladoY, ladoZ);

            bool medidasTrianguloValidas = ClassificadorDeTriangulos.MedidasFormamTrianguloValido(ladoX, ladoY, ladoZ);

            if (medidasTrianguloValidas)
            {
                string tipoTriangulo = ClassificadorDeTriangulos.ClassificarTriangulo(ladoX, ladoY, ladoZ);

                Console.WriteLine($"\nO triângulo é {tipoTriangulo}");
            }
            else
            {
                Console.WriteLine("\nOs valores informados não formam um triângulo válido");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Deseja continuar? (s/N) ");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Classsificador de triângulos");
        Console.WriteLine("-----------------------------------------");
    }

    static int LerLado(string nomeLado)
    {

        int valor;

        while (true)
        {
            Console.Write($"Informe o valor do lado {nomeLado}: ");
            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);
            if (conseguiuConverter)
                break;
        }
        return valor;
    }

    static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Valores informados: ");
        Console.WriteLine("Lado X: " + ladoX);
        Console.WriteLine("Valores informados: ");
        Console.WriteLine("Lado Y: " + ladoY);
        Console.WriteLine("Valores informados: ");
        Console.WriteLine("Lado Z: " + ladoZ);
        Console.WriteLine("-----------------------------------------");
    }

   
}
