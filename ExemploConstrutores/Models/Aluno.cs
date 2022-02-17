namespace ExemploConstrutores.Models
{
    /**
			* Construtor de Herança
			* base se refere a classe mãe
			*/
		public class Aluno : Pessoa
    {
			public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
			{
				System.Console.WriteLine("Construtor da classe Aluno");
			}
    }
}
