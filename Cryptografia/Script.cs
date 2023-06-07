
namespace Cryptografia
{
    public class Script
    {
        public static void Criptografar(string text, string key, int keyNumber)
        {
            string result = Calculate(text, key, keyNumber, "+");

            Continue(result);
        }

        public static void Descriptografar(string text, string key, int keyNumber)
        {
            string result = Calculate(text, key, keyNumber, "-");

            Continue(result);
        }

        static string Calculate(string text, string key, int keyNumber, string operador)
        {
            string result = "";
            text = text.ToUpper();
            key = key.ToUpper();
            int j = 0;
            int m = 0;

            for(int k = 0; k < keyNumber; k++)
            {
                for (int i = 0; i < text.Length; i++, j++)
                {
                    j = (j == key.Length) ? 0 : j;
                    char cT = text[i];
                    char cK = key[j];
                    int ascT = Convert.ToInt32(cT);
                    int ascK = Convert.ToInt32(cK);
                    int add = ascK - 65;


                    if (ascT != 32)
                    {
                        ascT = (operador == "+") ? ascT += add : ascT -= add;

                        if (ascT < 65)
                        {
                            ascT = (91 - (65 - ascT));
                        }
                        else if (ascT > 90)
                        {
                            ascT = (64 + (ascT - 90));
                        }
                    }

                    result += Convert.ToChar(ascT);
                }

                if (m == 24)
                {
                    key = Changekey(key);
                    m = 0;
                }

                m++;
                text = result;
                result = "";
                j = 0;
            }
            
            return text;
        }

        static string Changekey(string key)
        {
            char firstLetter = key[0];
            key = key.Substring(1);
            key += firstLetter;
            return key;
        }

        static void Continue(string result)
        {
            Console.Clear();

            Console.WriteLine("Este é o seu resultado: ");
            Console.WriteLine(result);

            Console.ReadLine();

            Console.WriteLine("Deseja voltar ao menu? 1. Sim || 2. Não");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Program.Menu();
            }
        }
    }
}
