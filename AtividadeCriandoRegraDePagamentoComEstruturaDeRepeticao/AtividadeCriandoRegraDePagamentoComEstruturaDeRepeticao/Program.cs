namespace AtividadeCriandoRegraDePagamentoComEstruturaDeRepeticao;

class Program
{
   static void Main(string[] args)
   {
        //Formas de Pagamento
        //Se o valor de compra for maior que R$1.000 pode parcelar em 3 vezes.
        //Se não for, apenas a vista.

        decimal valorCompra;
        int numeroParcelas = 3;
        decimal valorParcela;
        decimal valorMínimoParcelar = 1.000;

        console.Write("Digite o valor da compra:");
        valorCompra = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Valor a vista: {0:c}", valorCompra);

        if (valorCompra >= valorMínimoParcelar) 
        {
            valorParcela = valorCompra / numeroParcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", 
                numeroParcelas, valorParcela);
        }
        Console.WriteLine();
   }
}