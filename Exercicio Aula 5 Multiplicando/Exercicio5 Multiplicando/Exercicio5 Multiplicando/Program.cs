namespace Exercicio5 
{
    class Program
    {

        static void Main(string[] args) 
        {
            //Obter o valores
            Console.WriteLine("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            //Calcular
            decimal resultado = quantidade * valor;

            //Exibir (esse {0:C} é para converter para moeda
            Console.WriteLine("Total da compra: {0:C}", resultado);
            Console.ReadLine();
                
        }
    }

}

