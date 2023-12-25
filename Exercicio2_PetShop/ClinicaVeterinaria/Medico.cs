using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using end = Exercicio2_PetShop.Endereco;

namespace Exercicio2_PetShop.ClinicaVeterinaria
{
    internal class Medico
    {
        public Medico(string nome, int idade, string documento, end.Endereco medicoEndereco)
        {
            Nome = nome;
            Idade = idade;
            Documento = documento;
            MedicoEndereco = medicoEndereco;
        }

        private string Nome { get; }
        private int Idade { get; }
        private string Documento {  get; }
        private end.Endereco MedicoEndereco { get; }

        public void RegistrarMedico() 
        {

        }

    }
}
