using NaPratica.Alura.Filmes;

List<Filmes> movies = new List<Filmes>();

Filmes meuMalvadoFavorito = new Filmes("Meu Malvado Favorito",95);
meuMalvadoFavorito.Elenco.Add("Steve Carell");
meuMalvadoFavorito.Elenco.Add("Jason Segel");
meuMalvadoFavorito.Elenco.Add("Russell Brand");
meuMalvadoFavorito.Elenco.Add("Julie Andrews");
meuMalvadoFavorito.Elenco.Add("Will Arnett");
meuMalvadoFavorito.Elenco.Add("Miranda Cosgrove");
meuMalvadoFavorito.Elenco.Add("Dana Gaier");
meuMalvadoFavorito.Elenco.Add("Elsie Fisher");
movies.Add(meuMalvadoFavorito);


Filmes leo = new Filmes("Leo", 102);
leo.Elenco.Add("Adam Sandler");
leo.Elenco.Add("Bill Burr");
leo.Elenco.Add("Cecily Strong");
movies.Add(leo);

Filmes godzilla2024 = new Filmes("Godzilla x Kong: The New Empire", 0);
godzilla2024.Elenco.Add("Dan Stevens");
godzilla2024.Elenco.Add("Rebecca Hall");
godzilla2024.Elenco.Add("Brian Tyree Henry");
movies.Add(godzilla2024);

Filmes jurassicPark = new Filmes("Jurassic Park - Parque dos dinossauros", 126);
jurassicPark.Elenco.Add("Sam Neill");
jurassicPark.Elenco.Add("Laura Dern");
jurassicPark.Elenco.Add("Jeff Goldblum");
jurassicPark.Elenco.Add("Richard Attenborough");
jurassicPark.Elenco.Add("Joseph Mazzello");
jurassicPark.Elenco.Add("Ariana Richards");
jurassicPark.Elenco.Add("Samuel L. Jackson");
jurassicPark.Elenco.Add("Wayne Knight");
jurassicPark.Elenco.Add("Bob Peck");
jurassicPark.Elenco.Add("Martin Ferrero");
jurassicPark.Elenco.Add("B.D. Wong");
movies.Add(jurassicPark);


Filmes tropaDeElite = new Filmes("Tropa de Elite", 118);
tropaDeElite.Elenco.Add("Wagner Moura");
tropaDeElite.Elenco.Add("André Ramiro");
tropaDeElite.Elenco.Add("Caio Junqueira");
tropaDeElite.Elenco.Add("Milhem Cortaz");
tropaDeElite.Elenco.Add("Fernanda Machado");
tropaDeElite.Elenco.Add("André Di Mauro");
tropaDeElite.Elenco.Add("Paulo Vilela");
tropaDeElite.Elenco.Add("Fernanda de Freitas");
tropaDeElite.Elenco.Add("Maria Ribeiro");
tropaDeElite.Elenco.Add("Fábio Lago");
movies.Add(tropaDeElite);

foreach (Filmes obras in movies)
{
    Console.WriteLine($"Nome do Filme: {obras.Titulo}");
    Console.WriteLine($"Duração em minutos: {obras.Duracao}");
    Console.WriteLine("Grande elenco:");
    /*foreach (string artista in obras.Elenco)
    {
        Console.WriteLine(artista); 
    }*/
    Console.WriteLine($"Elenco: {string.Join(", ",obras.Elenco)}");
    Console.WriteLine("\n__________________\n");
}

