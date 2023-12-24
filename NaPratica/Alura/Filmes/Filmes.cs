using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPratica.Alura.Filmes
{
    public class Filmes
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; } //Em minutos
        public List<string> Elenco { get; set; }
        
        
        public Filmes(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
            Elenco = new List<string>();
        }





    }
}
