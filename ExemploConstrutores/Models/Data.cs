namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
				private bool mesValido;

				public int GetMes()
				{
					return this.mes;
				}

				public void SetMes(int mes)
				{
					if (mes > 0 && mes <= 12)
					{
						this.mes = mes;
						this.mesValido = true;
					}
					else
					{
						this.mesValido = false;
					}
				}

				/**
				* Propriedades nada mais é do que uma maneira de unificar o get e set, podendo ter validações ou não.
				*/
				public int Mes
				{
					get
					{
						return this.mes;
					}

					set
					{
						if (value > 0 && value <= 12)
						{
							this.mes = value;
							this.mesValido = true;
						}
						else
						{
							this.mesValido = false;
						}
					}
				}



				public void ApresentarMes()
				{
					if(this.mesValido)
					{
						System.Console.WriteLine(this.mes);
					}
					else
					{
						System.Console.WriteLine("Mes inválido");
					}
				}

    }
}
