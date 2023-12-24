using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPratica.Alura.Filmes
{
    public class Artista
    {

        public string Nome {  get; set; }
        public int Idade { get; set; }
        public List<Filmes> ArtistaFilmes { get; set; }
        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            ArtistaFilmes = new List<Filmes>();
        }

        //Falta criar o método para incluir o filme na lista do artista
    }
}
