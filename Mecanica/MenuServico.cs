using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class MenuServico
    {
        private Profissional prof = new Profissional();
        private Cliente cli = new Cliente();
        private Servico serv = new Servico();
        private List<Servico> listaDeServicos = new List<Servico>();
       

        private int tamanhoLista;
        private int opcao;

        public void menuServico()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Consultar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Alterar");
            Console.WriteLine("4 - Excluir");
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

            //tamanhoLista = listaDeServicos.Count;
            if (tamanhoLista > 0)
            {
                for (int i = 0; i < tamanhoLista; i++)
                {
                    Console.WriteLine("id: " + i);
                    Console.WriteLine("Descricao: " + listaDeServicos[i].getDescricao());

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
            
            Console.Write("Descricao: ");
            string descricao = (Console.ReadLine());
            serv.setDescricao(descricao);
            listaDeServicos.Add(serv);
            tamanhoLista++;
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
                Console.WriteLine("Descricao: " + listaDeServicos[i].getDescricao());
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.WriteLine("Selecione o ID para cancelar");
            opcao = int.Parse(Console.ReadLine());
            listaDeServicos.RemoveAt(opcao);
            Console.WriteLine("Servico removido ! ");
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            Console.ReadLine();
            menuServico();
        }

        void alterarServico()
        {
            Console.Clear();
            if (consultaTamnhoLista() > 0)
            {
                for (int i = 0; i < consultaTamnhoLista(); i++)
                {

                    Console.WriteLine("id: " + i);
                    Console.WriteLine("Descricao: " + listaDeServicos[i].getDescricao());
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
            Console.Write("Descricao: ");
            string descricao = (Console.ReadLine());
            serv.setDescricao(descricao);
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
