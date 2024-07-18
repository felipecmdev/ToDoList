using System;

namespace Projeto
{
    internal class Menu
    {
        static void Main()
        {
            Tarefas tarefas = new Tarefas();
            while (true)
            {
                Console.WriteLine("O que deseja fazer:");
                string opcao = Console.ReadLine();
                Console.Clear();

                if (opcao == "adicionar tarefa" || opcao == "adicionar tarefas")
                {
                    Console.WriteLine("Escreva sua tarefa do dia e sua descrição: ");
                    string titulo = Console.ReadLine().ToUpper();
                    tarefas.Log.Add(titulo);

                    Console.WriteLine();
                    
                    string descricao = Console.ReadLine();
                    tarefas.Log.Add(descricao);
                    Console.Clear();
                }
                else if (opcao == "remover tarefa")
                {
                    tarefas.RemoverTarefa();
                    Console.WriteLine("Última tarefa apagadas com sucesso");
                    Console.Read();
                    Console.Clear();
                }
                else if (opcao == "listar tarefas" || opcao == "listar tarefa")
                {
                    tarefas.ListarTarefas();
                }
                else if (opcao == "salvar tarefas" || opcao == "salvar tarefa")
                {
                    tarefas.SalvarTarefas();
                    Console.WriteLine();
                    break;
                }
            }
            Console.WriteLine("Tarefas salvas com sucesso!");
            Console.WriteLine();
        }
    }
}
