namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
			private string nome;
			private string sobrenome;

			/**
			* Construtor Vazio/Padrão
			* Como reconheço que é um construtor: Tem o mesmo nome da Classe e não tem retorno.
			* Uma classe pode ter varios construtores.
			*/
			// public Pessoa()
			// {
			// 	nome = string.Empty;
			// 	sobrenome = string.Empty;
			// }


			/**
			* Construtor
			* Recebe nome e sobrenome.
			*/
			public Pessoa(string nome, string sobrenome)
			{
				this.nome = nome;
				this.sobrenome = sobrenome;
				System.Console.WriteLine("Construtor classe pessoa!");
			}

			/**
			* Método Apresentar.
			* Exibe o nome e sobrenome.
			*/
			public void Apresentar()
			{
				System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
			}


    }
}
