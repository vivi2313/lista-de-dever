using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o nome de usuário: ");
        string usuario = Console.ReadLine();

        if (usuario == "admin" || usuario == "supervisor")
        {
            Console.WriteLine("Acesso concedido");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }

    }
}