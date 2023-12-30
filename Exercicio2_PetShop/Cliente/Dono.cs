using end = Exercicio2_PetShop.Endereco;

namespace Exercicio2_PetShop.Cliente
{
    public class Dono
    {
        
        public string Nome {  get; }
        public string CPF { get; }
        public end.Endereco Endereco{get;}
        public Dono(string nome, string cpf, end.Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            this.Endereco = endereco;
        }

    
    
    }
}
