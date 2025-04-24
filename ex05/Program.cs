class Program
{
    public static void Main()
    {
        bool ehClienteVip = false;
        int compras = 2;

        if (!ehClienteVip && compras > 10)
        {
            Console.WriteLine("Ganha desconto especial");
        }
        else
        {
            Console.WriteLine("Não ganha desconto especial");
        }
    }
}