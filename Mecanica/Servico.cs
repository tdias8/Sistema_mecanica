using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Servico
    {
        private string descricao;
        private string data;
        private string hora;
        private Profissional profissional;
        private Cliente cliente;
        private string status;

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public void setData(string data)
        {
            this.data = data;
        }
        public string getData()
        {
            return data;
        }
        public void sethora(string hora)
        {
            this.hora = hora;
        }
        public string getHora()
        {
            return hora;
        }
        public void setProfissional(Profissional profissional)
        {
            this.profissional = profissional;
        }
        public Profissional getProfissional()
        {
            return this.profissional;
        }
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
        public Cliente getCliente()
        {
            return this.cliente;
        }
    }
}
