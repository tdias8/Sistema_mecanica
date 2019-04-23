using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Clientes
    {
      private string cpf;
      private string nome;
      private int telefone;
      private string email;
      private string endereco;
      private DateTime dataDeNascimento;
      private char sexo;
      private string estadoCivil;
      private Boolean ativo;


        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        
        public string getCpf ()
        {
            return cpf;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setTelefone(int telefone)
        {
            this.telefone = telefone;
        }
        public int getTelefone()
        {
            return telefone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return endereco;
        }
    }

}
