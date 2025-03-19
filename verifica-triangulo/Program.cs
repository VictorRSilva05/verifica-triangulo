using System.Security.Principal;

namespace verifica_triangulo
{
    //Victor Rafael da Silva
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Classsificador de triângulos");
                Console.WriteLine("-----------------------------------------");

                int ladoX, ladoY, ladoZ;

                while (true)
                {
                    Console.Write("Informe o valor do lado X: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoX);
                    if (conseguiuConverter)
                        break;
                }
         
                Console.Write("Informe o valor do lado X: ");
                ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado X: ");
                ladoZ = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Valores informados: ");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Valores informados: ");
                Console.WriteLine("Lado Y: " + ladoY);
                Console.WriteLine("Valores informados: ");
                Console.WriteLine("Lado Z: " + ladoZ);

                bool medidasTrianguloValidas =
                    ladoX + ladoY > ladoZ &&
                    ladoX + ladoZ > ladoY &&
                    ladoY + ladoZ > ladoX;

                if (medidasTrianguloValidas == true)
                {
                    string tipoTriangulo = "Não classificado";

                    if (ladoX == ladoY && ladoY == ladoZ)
                    {
                        tipoTriangulo = "Equilátero";
                    }
                    else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                    {
                        tipoTriangulo = "Escaleno";
                    }
                    else
                    {
                        tipoTriangulo = "Isósceles";
                    }
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
    }
}
