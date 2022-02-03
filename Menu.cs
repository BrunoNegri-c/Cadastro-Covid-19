using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploTeste
{
    public class Menu
    {
        public static void show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var opcao = short.Parse(Console.ReadLine());
            HandleMenuOption(opcao);
        }

        public static void DrawScreen()
        {
           Console.Write("+----------------------------------------+");
           Console.Write("\n");
           Console.Write("|                                        |");
           Console.Write("\n");
           Console.Write("|                                        |");
           Console.Write("\n"); 
           Console.Write("|                                        |"); 
           Console.Write("\n"); 
           Console.Write("|                                        |");  
           Console.Write("\n");
           Console.Write("|                                        |");   
           Console.Write("\n");
           Console.Write("|                                        |");
           Console.Write("\n");
           Console.Write("|                                        |");
           Console.Write("\n");
           Console.Write("|                                        |");
           Console.Write("\n");
           Console.Write("|                                        |"); 
           Console.Write("\n");
           Console.Write("+----------------------------------------+");
        }

                public static void WriteOptions()
        {
            Console.SetCursorPosition(1,1);
            Console.WriteLine("Bem vindo ao Cadastro online da covid 19");
            Console.SetCursorPosition(3,2);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("1 - Novo arquivo de cadastro");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("2 - Agendamento de teste da covid");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,9);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1 : Cadastro.show();
                break;
                case 2 : Agendamento.show();
                break;
                case 0 : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: show();
                break;
            }
        }

    }
}