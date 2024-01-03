using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Funcionarios.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        private string Nome {  get; set; }
        public double Salario { get; set; }

        public virtual void Bonificacao()
        {
            this.Salario *= 1.1;
            Console.WriteLine(Salario);

        }
    }
}
