using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Servico
    {
        private string descricao;

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return descricao;
        }
    }
}
