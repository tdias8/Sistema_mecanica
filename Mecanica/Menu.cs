using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Menu
    {
        MenuCliente cli = new MenuCliente();
        MenuProfissional prof = new MenuProfissional();


        public void menuInicial()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Agenda");
            Console.WriteLine("2 - Clientes");
            Console.WriteLine("3 - Funcionarios");
            Console.WriteLine("4 - Relatorios ");
            Console.WriteLine("5 - Servicos"); 
            Console.WriteLine("6 - Sair");
            Console.WriteLine("----------------------------------------------");

            int menu = int.Parse(Console.ReadLine());

            switch(menu)
            {
                case 1:
                //------------------Agenda--------------------------------------------
                    break;

                case 2:
                    //------------------clientes--------------------------------------------
                    cli.menuCliente();
                    menuInicial();
                    break;
                case 3:
                //------------------Profissionais--------------------------------------------
                    
                    break;
                case 4:
                //------------------Relatorios--------------------------------------------
                    break;
                case 5:
                //------------------Servicos--------------------------------------------
                    break;
                case 6:
                //------------------Sair--------------------------------------------
                    break;
                default:
                    Console.WriteLine("Comando invalido!");
                    menuInicial();
                    break;
            }
        }

















        public void  menuCrud()
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Alterar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Consultar");
            Console.WriteLine("4 - Excluir ");
            Console.WriteLine("5 - Voltar ");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
