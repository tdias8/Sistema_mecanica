using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class MenuProfissional
    {
        private Profissional prof = new Profissional();
        private List<Profissional> listaDeProfissionais = new List<Profissional>();

        private int tamanhoLista;
        private int opcao;

        public void menuProfissional()
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
                    consultarProfissional();
                    break;
                case 2:
                    inserirProfissional();
                    break;
                case 3:
                    alterarProfissional();
                    break;
                case 4:
                    excluirProfissional();
                    break;
                case 5:
                    break;

                default:
                    Console.WriteLine("Comando invalido!");
                    Console.WriteLine("Pressione enter para retornar ao menu principal");
                    Console.ReadLine();
                    menuProfissional();
                    break;
            }
        }

       public  void consultarProfissional()
        {
            Console.Clear();
            if (tamanhoLista > 0)
            {
                for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine("Cpf: " + listaDeProfissionais[i].getCpf());
                Console.WriteLine("Nome: " + listaDeProfissionais[i].getNome());
                Console.WriteLine("Telefone: " + listaDeProfissionais[i].getTelefone());
                Console.WriteLine("Email: " + listaDeProfissionais[i].getEmail());

            }
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
            }
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            menuProfissional();
        }
         void inserirProfissional()
        {
            Console.WriteLine("Preencha os dados");
            Console.Write("Cpf: ");
            string cpf = (Console.ReadLine());
            prof.setCpf(cpf);
            Console.Write("Nome: ");
            string nome = (Console.ReadLine());
            prof.setNome(nome);
            Console.Write("Telefone: ");
            int telefone = int.Parse(Console.ReadLine());
            prof.setTelefone(telefone);
            Console.Write("Email: ");
            string email = (Console.ReadLine());
            prof.setEmail(email);
            listaDeProfissionais.Add(prof);
            tamanhoLista++;
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            menuProfissional();
        }

         void excluirProfissional()
        {
            Console.Clear();
            for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine("id: " + i);
                Console.WriteLine("Cpf: " + listaDeProfissionais[i].getCpf());
                Console.WriteLine("Nome: " + listaDeProfissionais[i].getNome());
                Console.WriteLine("Telefone: " + listaDeProfissionais[i].getTelefone());
                Console.WriteLine("Email: " + listaDeProfissionais[i].getEmail());
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.WriteLine("Selecione o ID para excluir");
            opcao = int.Parse(Console.ReadLine());
            listaDeProfissionais.RemoveAt(opcao);
            Console.WriteLine("Cadastro removido ! ");
            tamanhoLista--;
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();
            menuProfissional();
        }
    
         void alterarProfissional()
        {
            Console.Clear();
            if (tamanhoLista > 0)
            {
                for (int i = 0; i < tamanhoLista; i++)
                {

                    Console.WriteLine("id: " + i);
                    Console.WriteLine("Cpf: " + listaDeProfissionais[i].getCpf());
                    Console.WriteLine("Nome: " + listaDeProfissionais[i].getNome());
                    Console.WriteLine("Telefone: " + listaDeProfissionais[i].getTelefone());
                    Console.WriteLine("Email: " + listaDeProfissionais[i].getEmail());
                    Console.WriteLine("-------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado!");
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();

                menuProfissional();
            }
            Console.WriteLine("Selecione o ID para alterar");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Preencha os dados");
            Console.Write("Cpf: " + listaDeProfissionais[opcao].getCpf());
            Console.Write("Nome: " + listaDeProfissionais[opcao].getNome());
            Console.Write("Telefone: " + listaDeProfissionais[opcao].getTelefone());
            Console.Write("Email: " + listaDeProfissionais[opcao].getEmail());
            Console.WriteLine("Cadastro alterado ! ");
            Console.WriteLine("Pressione enter para retornar ao menu principal");
            Console.ReadLine();

            menuProfissional();

        }
        public int consultaTamnhoLista()
        {
            return tamanhoLista;
        }
    }
}
