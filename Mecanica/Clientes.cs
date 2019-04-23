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
      private Boolean ativo = true;


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
         public void setDataDeNascimento(DateTime dataDeNascimento)
        {
            this.dataDeNascimento = dataDeNascimento;
        }
        public DateTime getDeNascimento()
        {
            return DeNascimento;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return sexo;
        }
        public void setEstadoCivil(string estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }
        public string getestadoCivilo()
        {
            return estadoCivil;
        }
        public void setAtivo(string ativo)
        {
            this.ativo = ativo;
        }
        public string getAtivo()
        {
            return ativo;
        }
       
    }

}
