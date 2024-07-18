using System.IO;
using System.Collections.Generic;
using System;

namespace Projeto
{
    internal class Tarefas
    {
        public List<string> Log { get; set; }

        public Tarefas()
        {
            Log = new List<string>();
        }

        public void ListarTarefas()
        {
            if (Log.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                foreach (string lista in Log)
                {
                    Console.WriteLine(lista);
                    Console.WriteLine();
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
        public void SalvarTarefas()
        {
            if (Log.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                string caminho = @"D:\codes\C#\Primeiro_Projeto\ListaDeAfazeres.txt";

                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    DateTime now = DateTime.Now;
                    sw.WriteLine(now.ToShortDateString());
                    sw.WriteLine("----------");
                    foreach (string tarefas in Log)
                    {
                        sw.WriteLine(tarefas);
                        sw.WriteLine();
                    }
                }
            }
        }

        public void RemoverTarefa()
        {
            if (Log.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Log.RemoveRange(Log.Count - 2, 2);
            }
        }
    }
}
