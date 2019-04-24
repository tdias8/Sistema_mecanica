using System;

namespace Mecanica
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu;

            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Agenda");
            Console.WriteLine("2 - Clientes");
            Console.WriteLine("3 - Funcionarios");
            Console.WriteLine("4 - Relatorios");
            Console.WriteLine("5 - Servicos");         
            Console.WriteLine("6 - Sair");
            Console.WriteLine("----------------------------------------------");


            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                   
                    break;
                case 2:
                    Console.WriteLine("Selecione uma opção");
                    Console.WriteLine("1 - Consultar");
                    Console.WriteLine("2 - Cadastrar");
                    Console.WriteLine("3 - Alterar");
                    Console.WriteLine("4 - Excluir");   
                    Console.WriteLine("5 - Voltar");
                    Console.WriteLine("----------------------------------------------");

                   int menuCliente = int.Parse(Console.ReadLine());

                    if (menuCliente == 1){

                    }
                    else if (menuCliente == 2){
                        Cliente cli1 = new Cliente();
                        Cliente cli2 = new Cliente();
                        Cliente cli3 = new Cliente();

                        Console.WriteLine("Preencha os dados");
                        Console.Write("Cpf: ");
                        string cpf = (Console.ReadLine());
                        cli1.setCpf(cpf);
                        Console.Write("Nome: ");
                        string nome = (Console.ReadLine());
                        cli1.setNome(nome);
                        Console.Write("Telefone: ");
                        int telefone = int.Parse(Console.ReadLine());
                        cli1.setTelefone(telefone);
                        Console.Write("Email: ");
                        string email = (Console.ReadLine());
                        cli1.setEmail(email);
                        Console.Write("Endereco: ");
                        string endereco = (Console.ReadLine());
                        cli1.setEndereco(endereco);
                        Console.Write("Cpf: ");
                        DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());
                        cli1.setDataDeNascimento(dataDeNascimento);
                        Console.Write("Cpf: ");
                        char sexo = char.Parse(Console.ReadLine());
                        cli1.setSexo(sexo);
                        Console.Write("Cpf: ");
                        string estadoCivil = (Console.ReadLine());
                        cli1.setEstadoCivil(estadoCivil);
                    }
                    else if (menuCliente == 3){

                    }
                    else if (menuCliente == 4){

                    }
                    else if (menuCliente == 5){

                    }

                    break;
                case 3:
                    Console.WriteLine("Case 1");

                    break;
                case 4:
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                    Console.WriteLine("Case 1");
                    break;
                case 6:
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
