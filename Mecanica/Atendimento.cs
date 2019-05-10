using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Atendimento
    {
        private string descricao;
        private string data;
        private string hora;
        private string profissional;
        private string cliente;
        private int codStatus;
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
        public void setHora(string hora)
        {
            this.hora = hora;
        }
        public string getHora()
        {
            return hora;
        }
        public void setProfissional(string profissional)
        {
            this.profissional = profissional;
        }
        public string getProfissional()
        {
            return profissional;
        }
        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }
        public string getCliente()
        {
            return cliente;
        }
        public void setStatus(int codStatus)
        {
            if (codStatus == 2 )
            {
                this.status = "Realizado";

            }
            else if (codStatus == 3)
            {
                this.status = "Cancelado";

            }
            else
            {
                this.status = "Agendado";
            }
            
        }
        public string getStatus()
        {
            return status;
        }
    }
}
