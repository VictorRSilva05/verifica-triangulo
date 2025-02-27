using System.Security.Principal;

namespace verifica_triangulo
{
    //Victor Rafael da Silva
    internal class Program
    {
        static void Main(string[] args)
        {
            byte selector = default;
            float result = default;

            while (selector != 2)
            {
                Console.Clear();
                Console.WriteLine("1- Verificar triângulo \n2- Sair");
                Console.Write("\n> ");
                string auxSelector = Console.ReadLine();

                while(!byte.TryParse(auxSelector, out selector) || selector < 1 || selector > 2)
                {
                    Console.Write("Valor inválido, tente novamente: ");
                    auxSelector = Console.ReadLine();
                }

                Console.Clear();

                if (selector == 1)
                {
                    List<float> sides = new List<float>();
                    

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write($"Insira o {i + 1} número: ");
                        string input = Console.ReadLine();

                        while (!float.TryParse(input, out result) || result < 0)
                        {
                            Console.Write("Valor inválido, tente novamente: ");
                            input = Console.ReadLine();
                        }
                        sides.Add(result);
                    }
                    if (CalculadoraTriangulo.ValidaTriangulo(sides) == true)
                    {
                        Console.WriteLine(CalculadoraTriangulo.TipoTriangulo(sides));
                    }
                    else
                    {
                        Console.WriteLine("\nTriângulo inválido");
                    }
                    Console.Write("\nDigite qualquer tecla: ");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Fechando aplicação...");
        }
    }
}
