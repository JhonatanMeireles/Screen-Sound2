using end = Exercicio2_PetShop.Endereco;

namespace Exercicio2_PetShop.Cliente
{
    public class Dono
    {

        public string Nome {  get; }
        public string CPF { get; }
        public end.Endereco endereco{get; set;}
        public Dono(string nome, string cpf, end.Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            this.endereco = endereco;
        }
    
    
    }
}
