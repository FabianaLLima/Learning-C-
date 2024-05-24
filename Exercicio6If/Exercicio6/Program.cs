
namespace Exercicio6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número entre 1 e 10:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Operador: || (ou) && (e)

        if (n<1 || n > 10)
        {
            Console.WriteLine("É menor que 1 ou maior que 10");
        }

        else
        {
            Console.WriteLine("Obrigada");
        }

        Console.ReadLine();
    }
}   

