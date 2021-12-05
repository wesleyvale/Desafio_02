using System;


namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de alunos");

            int quant = Convert.ToInt32(Console.ReadLine());
            String[] alunos = new String[quant];
            int[] nota = new int[quant];
            String[] lista = new String[quant];

            Console.WriteLine("Nome do aluno(ENTER) Sua nota");
            
            for (int valorX = 0; valorX < alunos.Length; valorX++)
            {
                Console.WriteLine("Aluno: ");
                alunos[valorX] = Console.ReadLine();

                Console.WriteLine("nota: ");
                nota[valorX] = Convert.ToInt16(Console.ReadLine());

                if (nota[valorX] < quant)
                {
                    lista[valorX] = " " + alunos[valorX] + "0" + nota[valorX];
                }
                else
                {
                    lista[valorX] = alunos[valorX] + " " + "com " + nota[valorX];
                }
            }
             
            Array.Sort(lista);
            Console.WriteLine("O aluno com maior nota é o " + lista[ lista.Length - 1 ]);
         }
    }
}