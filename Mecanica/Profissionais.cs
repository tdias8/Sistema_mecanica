using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Profissionais
    {
        private String cpf;
        private String nome;
        private int telefone;
        private String email;

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getEstadoCivilo()
        {
            return estadoCivil;
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
        public void setEmail(string emailcpf)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
    }
}
