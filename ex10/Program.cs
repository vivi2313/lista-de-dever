class Program
{
    public static void Main()
    {
        int idade = 55;
        bool comportamentoSuspeito = false;

        if (idade < 18 || comportamentoSuspeito)
        {
            Console.WriteLine("Monitorar");
        }
        else
        {
            Console.WriteLine("Pessoa não suspeita");
        }
    }
}