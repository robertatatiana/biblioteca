using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        public Pessoa Cliente { get; set; }
        public Livro LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public DateTime? DataEstimadaDevolucao { get; set; }

        public Emprestimo(Pessoa cliente, Livro livroEmprestado)
        {
            Cliente = cliente;
            LivroEmprestado = livroEmprestado;
            DataEmprestimo = DateTime.Now;
            livroEmprestado.Disponivel = false;
            DataEstimadaDevolucao = DataEmprestimo.AddDays(7); 
        }

        public void Devolver()
        {
            DataDevolucao = DateTime.Now;
            LivroEmprestado.Disponivel = true;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine("");
            Console.WriteLine($"Empréstimo realizado por {Cliente.Nome}.");
            Console.WriteLine($"Livro emprestado: {LivroEmprestado.Titulo} - {LivroEmprestado.Autor}");
            Console.WriteLine($"Data de Empréstimo: {DataEmprestimo}");
            Console.WriteLine($"Data Estimada de Devolução: {DataEstimadaDevolucao}");

            if (DataDevolucao.HasValue)
            {
                Console.WriteLine($"Data de Devolução: {DataDevolucao}");

                if (DataDevolucao > DataEstimadaDevolucao)
                {
                    TimeSpan atraso = DataDevolucao.Value - DataEstimadaDevolucao.Value;
                    Console.WriteLine($"Atraso na devolução: {atraso.Days} dias");
                }
            }
        }
    }
}
