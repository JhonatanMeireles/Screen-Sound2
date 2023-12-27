using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_PetShop.Cliente
{
    public class Pet
    {
        
        public Pet(string nome, int idade, string raça, double peso, Dono paiDePet)
        {
            Nome = nome;
            Idade = idade;
            Raça = raça;
            Peso = peso;
            this.donoDoPet = paiDePet;
        }

        public string Nome { get;}
        public int Idade { get;}
        public string Raça { get;}
        public double Peso { get;}
        public Dono donoDoPet { get;}

        

    }
}
