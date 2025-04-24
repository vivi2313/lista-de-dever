class Program
{
    public static void Main()
    {
        bool temIngresso = true;
        bool documentoValido = true;

        if (temIngresso && documentoValido)
        {
            Console.WriteLine("Entrada permitida no evento");
        }
        else
        {
            Console.WriteLine("Entrada negada no evento");
        }
    }
}