using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Profissional
    {
        private String cpf;
        private String nome;
        private int telefone;
        private String email;
        


        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setNome(string nome)
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

       
    }
}
