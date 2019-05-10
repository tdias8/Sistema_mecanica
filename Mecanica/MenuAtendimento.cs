using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class MenuAtendimento
    {
       private Profissional prof = new Profissional();
        private Cliente cli = new Cliente();
        private Atendimento aten = new Atendimento();
        private List<Cliente> listaDeClientes = new List<Cliente>();
        private List<Atendimento> listaDeServicos = new List<Atendimento>();
        private List<Profissional> listaDeProfissional = new List<Profissional>();

        int tamanhoLista;
        int opcao;

        public void menuServico()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Consultar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Alterar");
            Console.WriteLine("4 - Cancelar");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine("----------------------------------------------");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    consultarServico();
                    break;
                case 2:
                    inserirServico();
                    break;
                case 3:
                    alterarServico();
                    break;
                case 4:
                    excluirServico();
                    break;
                case 5:
                    break;

                default:
                    Console.WriteLine("Comando invalido!");
                    Console.WriteLine("Pressione enter para retornar ao menu principal");
                    Console.ReadLine();
                    menuServico();
                    break;
            }
        }

       public void consultarServico()
        {
            Console.Clear();
            if (tamanhoLista > 0)
            {
                for (int i = 0; i < tamanhoLista; i++)
                {
                    Console.WriteLine("id: " + i);
                    Console.WriteLine("Data: " + listaDeServicos[i].getData());
                    Console.WriteLine("Hora: " + listaDeServicos[i].getHora());
                    Console.WriteLine("Cliente: " + listaDeServicos[i].getCliente());
                    Console.WriteLine("Descricao: " + listaDeServicos[i].getDescricao());
                    Console.WriteLine("Profissional: " + listaDeServicos[i].getProfissional());
                    Console.WriteLine("Status: " + listaDeServicos[i].getStatus());

                }
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            menuServico();
        }
        void inserirServico()
        {
            Console.WriteLine("Preencha os dados");
            Console.Write("Data: ");
            string data = (Console.ReadLine());
            aten.setData(data);
            Console.Write("Hora: ");
            string hora = (Console.ReadLine());
            aten.setHora(hora);
            Console.Write("Cliente: ");
            string cliente = (Console.ReadLine());
            aten.setCliente(cliente);
            Console.Write("Descricao: ");
            string descricao = (Console.ReadLine());
            aten.setDescricao(descricao);
            Console.Write("Profissional: ");
            string profissional = (Console.ReadLine());
            aten.setProfissional(profissional);
            aten.setStatus(1);
            tamanhoLista++;
            listaDeServicos.Add(aten);
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            menuServico();
        }

        void excluirServico()
        {
            Console.Clear();
            for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine("id: " + i);
                Console.WriteLine("Data: " + listaDeServicos[i].getData());
                Console.WriteLine("Hora: " + listaDeServicos[i].getHora());
                Console.WriteLine("Cliente: " + listaDeServicos[i].getCliente());
                Console.WriteLine("Descricao: " + listaDeServicos[i].getDescricao());
                Console.WriteLine("Profissional: " + listaDeServicos[i].getProfissional());
                Console.WriteLine("Status: " + listaDeServicos[i].getStatus());
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.WriteLine("Selecione o ID para cancelar");
            opcao = int.Parse(Console.ReadLine());
            listaDeServicos[opcao].setStatus(3);
            Console.WriteLine("Servico cancelado ! ");
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            Console.ReadLine();
            menuServico();
        }

        void alterarServico()
        {
            Console.Clear();
            if (tamanhoLista > 0)
            {
                for (int i = 0; i < tamanhoLista; i++)
                {

                    Console.WriteLine("id: " + i);
                    Console.WriteLine("Data: " + listaDeServicos[i].getData());
                    Console.WriteLine("Hora: " + listaDeServicos[i].getHora());
                    Console.WriteLine("Cliente: " + listaDeServicos[i].getCliente());
                    Console.WriteLine("Descricao: " + listaDeServicos[i].getDescricao());
                    Console.WriteLine("Profissional: " + listaDeServicos[i].getProfissional());
                    Console.WriteLine("Status: " + listaDeServicos[i].getStatus());
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();

                menuServico();
            }
            Console.WriteLine("Selecione o ID para alterar");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Preencha os dados");
            Console.Write("Data: ");
            string data = (Console.ReadLine());
            aten.setData(data);
            Console.Write("Hora: ");
            string hora = (Console.ReadLine());
            aten.setHora(hora);
            Console.Write("Cliente: ");
            string cliente = (Console.ReadLine());
            aten.setCliente(cliente);
            Console.Write("Descricao: ");
            string descricao = (Console.ReadLine());
            aten.setDescricao(descricao);
            Console.Write("Profissional: ");
            string profissional = (Console.ReadLine());
            aten.setProfissional(profissional);
            aten.setStatus(1);
            Console.WriteLine("Cadastro alterado ! ");
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();

            menuServico();

        }
        public int consultaTamnhoLista()
        {
            return tamanhoLista;
        }
    }
}
