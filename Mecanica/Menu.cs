using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Menu
    {

        public string menuInicial()
        {
            return "Selecione uma opção \n" + "1 - Agenda \n" + "2 - Clientes \n" + "3 - Funcionarios \n" + "4 - Relatorios \n" + "5 - Servicos \n" + "6 - Sair \n" + "----------------------------------------------";
        }

        public string menuCrud()
        {
            return "Selecione uma opção \n" + "1 - Consultar \n" + "2 - Cadastrar \n" + "3 - Alterar \n" + "4 - Excluir \n" + "5 - Voltar \n"+"----------------------------------------------";
        }
    }
}
