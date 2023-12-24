using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_PetShop.Endereco
{
    public class Endereco
    {
        public Endereco(string rua, int numero, string? complemento, string bairro, string cidade, string uf)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
        }

        public string Rua { get;}
        public int Numero { get;}
        public string? Complemento { get; }
        public string Bairro { get;}
        public string Cidade { get;}
        public string UF { get;}
    }
}
