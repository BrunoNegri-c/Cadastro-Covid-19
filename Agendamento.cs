using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace ExemploTeste
{
    public class Agendamento
    {
       
        public static void show ()
        {
         Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Digite seu Nome");
            Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Digite seu email");
            Console.ReadLine();
             Console.Write("\n");
            Console.WriteLine("Digite o telefone");
            Console.ReadLine();
             Console.Write("\n");
             Console.WriteLine("Digite a data para o teste");
             Console.ReadLine();
             Console.WriteLine("\n");
            Console.WriteLine("Digite a unidade no qual deseja efetuar o teste");
            Console.ReadLine();
             Console.Write("\n");
              Console.WriteLine("Agendamento efetuado com sucesso!");
              Console.WriteLine("De um Enter e aperte Esc para voltar ao menu principal");

              Start();
              Menu.show();


              
            
        }
         public static void Start()
        {
            var file = new System.Text.StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key !=ConsoleKey.Escape);

             

              


        }
    }
}