using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Agenda
    {
        string[] agenda = new string[5];
        


        MenuProfissional prof = new MenuProfissional();
        
        public void populaAgenda()
        {
            for(int i = 0; i < 5; i++)
            {
                if (agenda[i] == null)
                {
                    agenda[i] = "LIVRE";
                }
            }
        }
        public void consultaAgenda()
        {
            string[] listaAgenda = new string[prof.consultaTamnhoLista()]; 
            Console.Clear();
            populaAgenda();
            for (int i = 0; i <= prof.consultaTamnhoLista(); i++)
            {
                Console.WriteLine("Profissional " + i);
                Console.WriteLine("----------------SEGUNDA  TERCA   QUARTA  QUINTA  SEXTA----------------");

                for (int j = 0; j <= prof.consultaTamnhoLista(); j++)
                {

                    
                    Console.WriteLine("8H " + "1-" + agenda[0] + " " + "2-" + agenda[1] + "  " + "3-" + agenda[2] + "  " + "4-" + agenda[3] + " " + "5-" + agenda[4]);
                    Console.WriteLine("10H " + "1-" + agenda[0] + " " + "2-" + agenda[1] + "  " + "3-" + agenda[2] + "  " + "4-" + agenda[3] + " " + "5-" + agenda[4]);
                    Console.WriteLine("14H " + "1-" + agenda[0] + " " + "2-" + agenda[1] + "  " + "3-" + agenda[2] + "  " + "4-" + agenda[3] + " " + "5-" + agenda[4]);
                    Console.WriteLine("16H " + "1-" + agenda[0] + " " + "2-" + agenda[1] + "  " + "3-" + agenda[2] + "  " + "4-" + agenda[3] + " " + "5-" + agenda[4]);
                   
                }
            }
            Console.ReadLine();
        }
        public void marcarHora()
        {
            Console.WriteLine("Deseja marcar um horario ? S/N ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.Write("Selecione o profissional: ");
                Console.Write(": ");

            }
            else
            {
                Console.WriteLine("Pressione enter para retornar ao menu principal");
                Console.ReadLine();
            }
        }

    }
}
    

