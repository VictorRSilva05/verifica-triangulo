using System.Security.Principal;

namespace verifica_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte selector = default;

            while (selector != 2){
                Console.WriteLine("1- Verificar triângulo \n2- Sair");
                selector = byte.Parse(Console.ReadLine());

                if (selector != 2)
                {
                    List<float> sides = new List<float>();
                    float result = default;

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
                    foreach (float side in sides)
                    {
                        Console.WriteLine(side);
                    }
                }
            }
            Console.WriteLine("Fechando aplicação...");
        }
    }
}
