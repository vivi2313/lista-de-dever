class Program
{
    public static void Main()
    {
        bool cadastrado = true;
        bool cupomValido = false;
        bool jaUsouCupom = false;

        if (cadastrado && cupomValido && !jaUsouCupom)
        {
            Console.WriteLine("Promoção válida! Você pode usar o cupom.");
        }
        else
        {
            Console.WriteLine("Promoção inválida.");
        }
    }
}
