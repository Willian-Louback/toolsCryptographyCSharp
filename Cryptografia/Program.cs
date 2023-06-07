
namespace Cryptografia
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static public void Menu()
        {
            string message;
            string key;
            int keyNumber;

            Console.WriteLine("O que você deseja fazer? 1. Criptografar || 2. Descriptografar");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Digite o texto que você deseja criptografar: ");
                    message = Console.ReadLine();

                    Console.WriteLine("Digite a sua chave secreta: ");
                    key = Console.ReadLine();

                    Console.WriteLine("Digite o seu número secreto: ");
                    keyNumber = int.Parse(Console.ReadLine());

                    Script.Criptografar(message, key, keyNumber);
                    break;
                case 2:
                    Console.WriteLine("Digite o texto que você deseja descriptografar: ");
                    message = Console.ReadLine();

                    Console.WriteLine("Digite a sua chave secreta: ");
                    key = Console.ReadLine();

                    Console.WriteLine("Digite o seu número secreto: ");
                    keyNumber = int.Parse(Console.ReadLine());

                    Script.Descriptografar(message, key, keyNumber);
                    break;
                default:
                    Console.WriteLine("Digite um valor valido!");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
    }
}