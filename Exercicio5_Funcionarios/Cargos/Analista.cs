using Exercicio5_Funcionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Funcionarios.Cargos
{
    public class Analista : Funcionario
    {
        public Analista(string nome, double salario) : base(nome, salario)
        {
        }

        public override void Bonificacao()
        {
            this.Salario *= 1.3;
            Console.WriteLine(Salario);

        }
    }
}
