using System;

namespace Mecanica
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            int opcao;

            Console.WriteLine(menu.menuInicial());
            Cliente cli1 = new Cliente();
            Cliente cli2 = new Cliente();
            Profissional prof1 = new Profissional();
            Profissional prof2 = new Profissional();

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                   
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(menu.menuCrud());

                   int menuCliente = int.Parse(Console.ReadLine());

                    if (menuCliente == 1){
                        Console.Write("Cpf: " + cli1.getCpf());
                        Console.Write("Nome: " + cli1.getNome());
                        Console.Write("Telefone: " + cli1.getTelefone());
                        Console.Write("Email: " + cli1.getEmail());
                        Console.Write("Endereco: " + cli1.getEndereco());
                        Console.Write("Data de nascimento: " + cli1.getDataDeNascimento());
                        Console.Write("Sexo (F ou M ): " + cli1.getSexo());
                        Console.Write("Estado civil: " + cli1.getEstadoCivil());
                        
                        if (cli2.getNome() != null)
                        {
                            Console.Write("-----------------------------------");
                            Console.Write("Cpf: " + cli2.getCpf());
                            Console.Write("Nome: " + cli2.getNome());
                            Console.Write("Telefone: " + cli2.getTelefone());
                            Console.Write("Email: " + cli2.getEmail());
                            Console.Write("Endereco: " + cli2.getEndereco());
                            Console.Write("Data de nascimento: " + cli2.getDataDeNascimento());
                            Console.Write("Sexo (F ou M ): " + cli2.getSexo());
                            Console.Write("Estado civil: " + cli2.getEstadoCivil());
                        }


                    }
                    else if (menuCliente == 2){
                       

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
                        Console.Write("Data de nascimento: ");
                        DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());
                        cli1.setDataDeNascimento(dataDeNascimento);
                        Console.Write("Sexo (F ou M ): ");
                        char sexo = char.Parse(Console.ReadLine());
                        cli1.setSexo(sexo);
                        Console.Write("Estado civil: ");
                        string estadoCivil = (Console.ReadLine());
                        cli1.setEstadoCivil(estadoCivil);
                        Console.WriteLine("Cadastro concluido ! ");
                        Console.Write("Deseja cadastrar outro clientes ? ( S ou N): ");

                        char resp = char.Parse(Console.ReadLine());

                        if (resp == 's' ){
                            Console.WriteLine("Preencha os dados");
                            Console.Write("Cpf: ");
                            cpf = (Console.ReadLine());
                            cli2.setCpf(cpf);
                            Console.Write("Nome: ");
                             nome = (Console.ReadLine());
                            cli2.setNome(nome);
                            Console.Write("Telefone: ");
                             telefone = int.Parse(Console.ReadLine());
                            cli2.setTelefone(telefone);
                            Console.Write("Email: ");
                             email = (Console.ReadLine());
                            cli2.setEmail(email);
                            Console.Write("Endereco: ");
                             endereco = (Console.ReadLine());
                            cli2.setEndereco(endereco);
                            Console.Write("Data de nascimento: ");
                             dataDeNascimento = DateTime.Parse(Console.ReadLine());
                            cli2.setDataDeNascimento(dataDeNascimento);
                            Console.Write("Sexo (F ou M ): ");
                             sexo = char.Parse(Console.ReadLine());
                            cli2.setSexo(sexo);
                            Console.Write("Estado civil: ");
                             estadoCivil = (Console.ReadLine());
                            cli2.setEstadoCivil(estadoCivil);
                            Console.WriteLine("Cadastro concluido ! ");
                        }
                        else
                        {

                        }
                    }
                    else if (menuCliente == 3){
                        Console.Clear();
                        Console.WriteLine("Selecione uma opção para alterar");
                        Console.Write("1 - Nome: " + cli1.getNome());
                        Console.Write("2 - Nome: " + cli2.getNome());

                    }
                    else if (menuCliente == 4){

                    }
                    else if (menuCliente == 5){
                        return;
                    }

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Selecione uma opção");
                    Console.WriteLine("1 - Consultar");
                    Console.WriteLine("2 - Cadastrar");
                    Console.WriteLine("3 - Alterar");
                    Console.WriteLine("4 - Excluir");
                    Console.WriteLine("5 - Voltar");
                    Console.WriteLine("----------------------------------------------");

                    int menuFuncionario = int.Parse(Console.ReadLine());

                    if (menuFuncionario == 1)
                    {
                        Console.Write("Cpf: " + prof1.getCpf());
                        Console.Write("Nome: " + prof1.getNome());
                        Console.Write("Telefone: " + prof1.getTelefone());
                        Console.Write("Email: " + prof1.getEmail());
                        

                        if (prof2.getNome() != null)
                        {
                            Console.Write("-----------------------------------");
                            Console.Write("Cpf: " + prof2.getCpf());
                            Console.Write("Nome: " + prof2.getNome());
                            Console.Write("Telefone: " + prof2.getTelefone());
                            Console.Write("Email: " + prof2.getEmail());
                        }


                    }
                    else if (menuFuncionario == 2)
                    {


                        Console.WriteLine("Preencha os dados");
                        Console.Write("Cpf: ");
                        string cpf = (Console.ReadLine());
                        prof1.setCpf(cpf);
                        Console.Write("Nome: ");
                        string nome = (Console.ReadLine());
                        prof1.setNome(nome);
                        Console.Write("Telefone: ");
                        int telefone = int.Parse(Console.ReadLine());
                        prof1.setTelefone(telefone);
                        Console.Write("Email: ");
                        string email = (Console.ReadLine());
                        prof1.setEmail(email);
              
                        Console.Write("Deseja cadastrar outro funcionario ? ( S ou N): ");

                        char resp = char.Parse(Console.ReadLine());

                        if (resp == 's')
                        {
                            Console.WriteLine("Preencha os dados");
                            Console.Write("Cpf: ");
                            cpf = (Console.ReadLine());
                            prof2.setCpf(cpf);
                            Console.Write("Nome: ");
                            nome = (Console.ReadLine());
                            prof2.setNome(nome);
                            Console.Write("Telefone: ");
                            telefone = int.Parse(Console.ReadLine());
                            prof2.setTelefone(telefone);
                            Console.Write("Email: ");
                            email = (Console.ReadLine());
                            prof2.setEmail(email);
               
                            Console.WriteLine("Cadastro concluido ! ");
                        }
                        else
                        {

                        }
                    }
                    else if (menuFuncionario == 3)
                    {

                    }
                    else if (menuFuncionario == 4)
                    {

                    }
                    else if (menuFuncionario == 5)
                    {
                        Console.WriteLine(menu.menuInicial());
                        Console.ReadLine();
                    }

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
