using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTeste
{
    public class Cadastro
    {
        public static void show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Digite seu Nome");
            Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Digite sua idade");
            Console.ReadLine();
             Console.Write("\n");
            Console.WriteLine("Digite a Cidade no qual Reside atualmente");
            Console.ReadLine();
             Console.Write("\n");
            Console.WriteLine("Digite o seu E-mail");
            Console.ReadLine();
             Console.Write("\n");
             Console.WriteLine("Digite o numero de telefone");
             Console.ReadLine();
             Console.WriteLine("\n");
              Console.WriteLine("Cadastro efetuando com sucesso!");
              Console.WriteLine("\n"); 
              Console.WriteLine("De um enter e aperte Esc para voltar ao menu principal");
            Start(); 
            Menu.show();         

        }

          public static void Start()
        {
            var file = new StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key !=ConsoleKey.Escape);

            


        }

       
    }
}