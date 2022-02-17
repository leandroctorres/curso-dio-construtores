using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
				public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
						/** 1)
						* O Construtor serve para definir, no momento da sua instancia, alguns valores
						* para que o seu objeto seja inicializado com eles.
						* Ou seja, no momento que eu instancio, eu já tenho valores pré-definidos.
						*/
						System.Console.WriteLine("1)-------------------------");
						Pessoa p1 = new Pessoa("Leandro","Torres");
						p1.Apresentar();

						/** 2)
						* O Construtor privado não pode ser utilizado para instanciar objetos.
						* Não podemos ter uma instancia da classe Log.
						* Exemplo de uso: Para fazer conexão e registrar eventos.
						* Construtores privados são utilizados em padrão de projeto singleton.
						*/
						System.Console.WriteLine("2)-------------------------");
						Log log = Log.GetInstance();
						log.PropriedadeLog = "Teste instancia";

						Log log2 = Log.GetInstance();
						System.Console.WriteLine(log2.PropriedadeLog);

						/** 3)
						* Construtor da Herança
						*/
						System.Console.WriteLine("3)-------------------------");
						Aluno a1 = new Aluno("Jose","da Silva","Matemática");
						a1.Apresentar();

						/** 4)
						* O get e Set serve para que você possa atritubir um valor em uma variável de maneira controlada e com validações.
						*/
						System.Console.WriteLine("4)-------------------------");
						Data data = new Data();
						data.SetMes(20);
						data.ApresentarMes();
						data.SetMes(2);
						data.ApresentarMes();
						data.SetMes(15);
						data.ApresentarMes();

						/** 5)
						* Propriedades
						*/
						System.Console.WriteLine("5)-------------------------");
						data.Mes = 30;
						data.ApresentarMes();
						data.Mes = 6;
						data.ApresentarMes();

						/** 6)
						* O modificador readonly (somente leitura) bloqueia um campo contra alterações
						* que não sejam em sua inicialização ou pelo próprio construtor.
						*/

						/* 7)
						* Um delegate é uma maneira de passar um método como referência,
						* podendo ser usado omo um callback, aceitando qualquer método que contenha a mesma assinatura.
						*/
						//Duas maneiras:
						System.Console.WriteLine("7)-------------------------");
						Operacao op = new Operacao(Calculadora.Somar);
						op.Invoke(10, 10);
						Operacao op2 = Calculadora.Somar;
						op2(10,15);
						Operacao op3 = Calculadora.Subtrair;
						op3.Invoke(30,5);

						/** 8)
						* Multicast Delegate
						/ Invoca mais de uma operação.
						*/
						System.Console.WriteLine("8)-------------------------");
						Operacao opMCD = new Operacao(Calculadora.Somar);
						opMCD += Calculadora.Subtrair;
						opMCD.Invoke(30,20);

						/** 9)
						* Eventos é um mecanismo de comunicação entre objetos, onde existe um publisher(que realiza o evento)
						* e o subscriber(que ouve o evento).
						*/
						System.Console.WriteLine("9)-------------------------");
						Matematica m = new Matematica(10, 20);
						m.Somar();






        }
    }
}
