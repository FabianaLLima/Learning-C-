class Exercicio7Switch
{
    static void Main(string[] args)
    {
        int hora = DateTime.Now.Hour;
        string mensagem = string.Empty;
        switch(hora)
        {
            case 10:
                mensagem = "Hora do lanche";
                break;
            case 12:
                mensagem = "hora do Almoço";
                break;
            case 17:
                mensagem = "hora do lanche";
                break;
            default:
                mensagem = string.Empty;
                break;
        }

        Console.ReadLine();
    }
}

//Switch é indicado quando temos mais de uma possibilidade de escolha. Vários casos possiveis.