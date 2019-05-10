using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Menu
    {
        MenuCliente cli = new MenuCliente();
        MenuProfissional prof = new MenuProfissional();
        Agenda agenda = new Agenda();
        Relatorio relatorio = new Relatorio();
        MenuServico serv = new MenuServico();
        MenuAtendimento aten = new MenuAtendimento();


        public void menuInicial()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Agenda");
            Console.WriteLine("2 - Atendimentos");
            Console.WriteLine("3 - Clientes");
            Console.WriteLine("4 - Funcionarios");
            Console.WriteLine("5 - Relatorios ");
            Console.WriteLine("6 - Servicos"); 
            Console.WriteLine("7 - Sair");
            Console.WriteLine("----------------------------------------------");

            int menu = int.Parse(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    //------------------Agenda--------------------------------------------
                    agenda.consultaAgenda();
                    menuInicial();
                    break;
                case 2:
                    //------------------clientes--------------------------------------------
                    aten.menuServico();
                    menuInicial();
                    break;

                case 3:
                    //------------------clientes--------------------------------------------
                    cli.menuCliente();
                    menuInicial();
                    break;
                case 4:
                    //------------------Profissionais--------------------------------------------
                    prof.menuProfissional();
                    menuInicial();
                    break;
                case 5:
                    //------------------Relatorios--------------------------------------------
                    relatorio.menuRelatorio();
                    menuInicial();
                    break;
                case 6:
                    //------------------Servicos--------------------------------------------
                    serv.menuServico();
                    menuInicial();
                    break;
                case 7:
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
