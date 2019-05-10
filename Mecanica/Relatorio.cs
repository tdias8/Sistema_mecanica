using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Relatorio
    {
        List<Cliente> listaDeClientes = new List<Cliente>();
        List<Profissional> listaDeProfissionais = new List<Profissional>();
        List<Servico> listaDeServicos = new List<Servico>();
        MenuCliente cli = new MenuCliente();
        MenuProfissional prof = new MenuProfissional();
        MenuServico serv = new MenuServico();
        
        public void menuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Relatorio de clientes");
            Console.WriteLine("2 - Relatorio de serviços");
            Console.WriteLine("3 - Relatorio de profissionais");
            Console.WriteLine("4 - Relatorio de clientes por situaçao (ativo/inativo)");
            Console.WriteLine("5 - Agenda de determinado dia");
            Console.WriteLine("6 - Relatorio de serviços ja realizados por determinado cliente");
            Console.WriteLine("7 - Voltar");
            Console.WriteLine("----------------------------------------------");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    cli.consultarCliente();

                    break;
                case 2:
                    serv.consultarServico();
                    break;
                case 3:
                    prof.consultarProfissional();

                    break;
                case 4:
                    //consultaClienteAtivo();

                    break;
                case 5:
                    //consultaAgenda();
                    break;

                case 6:
                    //servicosRealizados();
                    break;
                case 7:
                    //servicosRealizados();
                    break;

                default:
                    Console.WriteLine("Comando invalido!");
                    Console.WriteLine("Pressione enter para retornar ao menu principal");
                    Console.ReadLine();
                    menuRelatorio();
                    break;
            }
            
        }
    }
}
