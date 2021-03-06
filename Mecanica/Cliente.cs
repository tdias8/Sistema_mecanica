﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Cliente
    {
        private int id;
        private string cpf;
        private string nome;
        private int telefone;
        private string email;
        private string endereco;
        private string dataDeNascimento;
        private char sexo;
        private string estadoCivil;
        private Boolean ativo = true;


        public void setId(int id)
        {
            this.id = id++;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
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
        public void setDataDeNascimento(string dataDeNascimento)
        {
            this.dataDeNascimento = dataDeNascimento;
        }
        public string getDataDeNascimento()
        {
            return dataDeNascimento;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public char getSexo()
        {
            return sexo;
        }
        public void setEstadoCivil(string estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }
        public string getEstadoCivil()
        {
            return estadoCivil;
        }
        public void setAtivo(Boolean ativo)
        {
            this.ativo = ativo;
        }
        public Boolean getAtivo()
        {
            return ativo;
        }

    }
}
