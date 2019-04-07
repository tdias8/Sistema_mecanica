using System;

namespace Mecanica
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Serviços");
            Console.WriteLine("3 - Funcionarios");
            Console.WriteLine("3 - Funcionarios");


            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Case 1");

                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.Read();
        }

        

    }
}
