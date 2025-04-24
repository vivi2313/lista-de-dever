class Program
{
    public static void Main()
    {
        int idade = 19;
        double renda = 2100.0;

        if (idade > 65 || renda < 2000.0)
        {
            Console.WriteLine("Está isento de imposto");
        }
        else
        {
            Console.WriteLine("Deve pagar imposto");
        }
    }
}

