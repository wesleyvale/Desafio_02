using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace desafio_2
{
    class dev
    {
        public string nome { get; set; }
        public bool desenvolvedor { get; set; }

        public void Contagem()
        {
            dev[] ubuntus =
            {
            new dev {nome = "Ubuntu1 Silva", desenvolvedor=true},
            new dev{nome = "Ubuntu2 Santos", desenvolvedor=true},
            new dev {nome = "Ubuntu3 Silva", desenvolvedor=false}
        };

            try
            {
                int ehDesenvolvedor = ubuntus.Count(u => u.desenvolvedor == true);
                Console.WriteLine("Apenas {0} são Devs ", ehDesenvolvedor);
            }
            catch (OverflowException)
            {
                return;
            }
        }
    }
}
