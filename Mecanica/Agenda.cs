using System;
using System.Collections.Generic;
using System.Text;

namespace Mecanica
{
    class Agenda
    {
        string[,] agenda = new string[5,5];


        public void consultaAgenda()
        {
            agenda[0, 1] = "8";
            agenda[0, 2] = "10";
            agenda[0, 3] = "14";
            agenda[0, 4] = "16";
            agenda[0, 1] = "8";
            agenda[0, 2] = "10";
            agenda[0, 3] = "14";
            agenda[0, 4] = "16";
            Console.ReadLine();
            
        }
        public void marcarHora()
        {
            Console.WriteLine("Deseja marcar um horario ? S/N ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.WriteLine("Deseja marcar um horario ? S/N ");
            }
        }

    }
}
    

