using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_PetShop.Cliente
{
    public class Pet
    {
        private static int codigoatual = 0;


        public Pet(string nome, int idade, string raca, double peso, Dono paiDePet)
        {
            Nome = nome;
            Idade = idade;
            Raca = raca;
            Peso = peso;
            this.donoDoPet = paiDePet;
            SKUPET = (codigoatual++);
        }

        public string Nome { get;}
        public int Idade { get;}
        public string Raca { get;}
        public double Peso { get;}
        public int SKUPET {  get;}
        public Dono donoDoPet { get;}        

    }
}
