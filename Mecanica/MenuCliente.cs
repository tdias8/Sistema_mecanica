using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class MenuCliente
    {
        private Cliente cli = new Cliente();
        private List <Cliente> listaDeClientes = new List<Cliente>();
        private int tamanhoLista = 0;

        public void menuCliente()
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
                    consultarCliente();

                    break;
                case 2:
                    inserirCliente();
                    break;
                case 3:
                    alterarCliente();

                    break;
                case 4:
                    excluirCliente();

                    break;
                case 5:

                    break;

                default:
                    Console.WriteLine("Comando invalido!");
                    Console.WriteLine("Pressione enter para retornar ao menu principal");
                    Console.ReadLine();
                    menuCliente();
                    break;
            }

            void inserirCliente()
            {

                Console.WriteLine("Preencha os dados");
                Console.Write("Cpf: ");
                string cpf = (Console.ReadLine());
                cli.setCpf(cpf);
                Console.Write("Nome: ");
                string nome = (Console.ReadLine());
                cli.setNome(nome);
                Console.Write("Telefone: ");
                int telefone = int.Parse(Console.ReadLine());
                cli.setTelefone(telefone);
                Console.Write("Email: ");
                string email = (Console.ReadLine());
                cli.setEmail(email);
                Console.Write("Endereco: ");
                string endereco = (Console.ReadLine());
                cli.setEndereco(endereco);
                Console.Write("Data de nascimento: ");
                string dataDeNascimento = (Console.ReadLine());
                cli.setDataDeNascimento(dataDeNascimento);
                Console.Write("Sexo (F ou M ): ");
                char sexo = char.Parse(Console.ReadLine());
                cli.setSexo(sexo);
                Console.Write("Estado civil: ");
                string estadoCivil = (Console.ReadLine());
                cli.setEstadoCivil(estadoCivil);

                listaDeClientes.Add(cli);
                Console.WriteLine("Cadastro concluido ! ");

                tamanhoLista++;
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();
                menuCliente();
            }
        }
          public  void consultarCliente()
            {
                Console.Clear();
                if (tamanhoLista > 0)
                {
                    for (int i = 0; i < tamanhoLista; i++)
                    {
                        
                        Console.WriteLine("id: " + i);
                        Console.WriteLine("Cpf: " + listaDeClientes[i].getCpf());
                        Console.WriteLine("Nome: " + listaDeClientes[i].getNome());
                        Console.WriteLine("Telefone: " + listaDeClientes[i].getTelefone());
                        Console.WriteLine("Email: " + listaDeClientes[i].getEmail());
                        Console.WriteLine("Endereco: " + listaDeClientes[i].getEndereco());
                        Console.WriteLine("Data de nascimento: " + listaDeClientes[i].getDataDeNascimento());
                        Console.WriteLine("Sexo (F ou M ): " + listaDeClientes[i].getSexo());
                        Console.WriteLine("Estado civil: " + listaDeClientes[i].getEstadoCivil());
                        Console.WriteLine("-------------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum registro encontrado!");
                }
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();
                menuCliente();
            }

            int opcao;

            void alterarCliente()
            {
                Console.Clear();
                if (tamanhoLista > 0)
                {
                    for (int i = 0; i < tamanhoLista; i++)
                    {
                        
                        Console.WriteLine("id: " + i);
                        Console.WriteLine("Cpf: " + listaDeClientes[i].getCpf());
                        Console.WriteLine("Nome: " + listaDeClientes[i].getNome());
                        Console.WriteLine("Telefone: " + listaDeClientes[i].getTelefone());
                        Console.WriteLine("Email: " + listaDeClientes[i].getEmail());
                        Console.WriteLine("Endereco: " + listaDeClientes[i].getEndereco());
                        Console.WriteLine("Data de nascimento: " + listaDeClientes[i].getDataDeNascimento());
                        Console.WriteLine("Sexo (F ou M ): " + listaDeClientes[i].getSexo());
                        Console.WriteLine("Estado civil: " + listaDeClientes[i].getEstadoCivil());
                        Console.WriteLine("-------------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum registro encontrado!");
                    Console.WriteLine("Pressione enter para retornar ao menu principal");
                    Console.ReadLine();

                    menuCliente();
                }
                Console.WriteLine("Selecione o ID para alterar");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("Preencha os dados");
                Console.Write("Cpf: ");
                string cpf = (Console.ReadLine());
                listaDeClientes[opcao].setCpf(cpf);
                Console.Write("Nome: ");
                string nome = (Console.ReadLine());
                listaDeClientes[opcao].setNome(nome);
                Console.Write("Telefone: ");
                int telefone = int.Parse(Console.ReadLine());
                listaDeClientes[opcao].setTelefone(telefone);
                Console.Write("Email: ");
                string email = (Console.ReadLine());
                listaDeClientes[opcao].setEmail(email);
                Console.Write("Endereco: ");
                string endereco = (Console.ReadLine());
                listaDeClientes[opcao].setEndereco(endereco);
                Console.Write("Data de nascimento: ");
                string dataDeNascimento = (Console.ReadLine());
                listaDeClientes[opcao].setDataDeNascimento(dataDeNascimento);
                Console.Write("Sexo (F ou M ): ");
                char sexo = char.Parse(Console.ReadLine());
                listaDeClientes[opcao].setSexo(sexo);
                Console.Write("Estado civil: ");
                string estadoCivil = (Console.ReadLine());
                listaDeClientes[opcao].setEstadoCivil(estadoCivil);
                Console.WriteLine("Cadastro alterado ! ");
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();

                menuCliente();
            }
            void excluirCliente()
            {
                
                Console.Clear();
                for (int i = 0; i < tamanhoLista; i++)
                {
                    Console.WriteLine("id: " + i);
                    Console.WriteLine("Cpf: " + listaDeClientes[i].getCpf());
                    Console.WriteLine("Nome: " + listaDeClientes[i].getNome());
                    Console.WriteLine("Telefone: " + listaDeClientes[i].getTelefone());
                    Console.WriteLine("Email: " + listaDeClientes[i].getEmail());
                    Console.WriteLine("Endereco: " + listaDeClientes[i].getEndereco());
                    Console.WriteLine("Data de nascimento: " + listaDeClientes[i].getDataDeNascimento());
                    Console.WriteLine("Sexo (F ou M ): " + listaDeClientes[i].getSexo());
                    Console.WriteLine("Estado civil: " + listaDeClientes[i].getEstadoCivil());
                    Console.WriteLine("-------------------------------------------------------");
                }
                    Console.WriteLine("Selecione o ID para excluir");
                opcao = int.Parse(Console.ReadLine());
                listaDeClientes.RemoveAt(opcao);
                Console.WriteLine("Cadastro removido ! ");
                tamanhoLista--;
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();
                menuCliente();
            }
        }
    }
