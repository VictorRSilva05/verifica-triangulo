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

                Console.Write("Informe o valor do lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado X: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado X: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

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
                
                if (medidasTrianguloValidas  ==  true)
                    Console.WriteLine("\nO triângulo é válido!");
                else
                    Console.WriteLine("\nOs valores informados não formam um triângulo válido");

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if( opcaoContinuar != "S")
                    break;
            }
        }
    }
}
