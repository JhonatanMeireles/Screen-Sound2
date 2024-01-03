using Exercicio5_Funcionarios.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Funcionarios.Cargos
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public override void Bonificacao()
        {
            this.Salario *= 1.2;
            Console.WriteLine(Salario);

        }
    }
}
