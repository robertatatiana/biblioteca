using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Roberta Tatiana");
        Livro livro = new Livro("Código Limpo", "Robert Cecil Martin");
        Pessoa pessoa2 = new Pessoa("Amanda");
        Livro livro2 = new Livro("Programação em C# para iniciantes", "Troy Dimes");
        Pessoa pessoa3 = new Pessoa("Luciana");
        Livro livro3 = new Livro("Design Patterns com C#", " Rodrigo Gonçalves Santana");

        Emprestimo emprestimo = new Emprestimo(pessoa, livro);
        Emprestimo emprestimo2 = new Emprestimo(pessoa2, livro2);
        Emprestimo emprestimo3 = new Emprestimo(pessoa3, livro3);

        emprestimo.Devolver();
        emprestimo2.Devolver();
        emprestimo3.Devolver();

        emprestimo.DataDevolucao = emprestimo.DataEstimadaDevolucao.Value.AddDays(2);
        emprestimo2.DataDevolucao = emprestimo.DataEstimadaDevolucao.Value.AddDays(3);
        emprestimo3.DataDevolucao = emprestimo.DataEstimadaDevolucao.Value.AddDays(-2);

        emprestimo.MostrarDetalhes();
        emprestimo2.MostrarDetalhes();
        emprestimo3.MostrarDetalhes();
    }
}