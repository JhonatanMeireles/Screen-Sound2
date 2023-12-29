﻿using Exercicio2_PetShop.Cliente;
using Exercicio2_PetShop.Endereco;


Dictionary<string, Dono> petDono = new Dictionary<string, Dono>();
Dictionary<string, Pet> petAnimal = new Dictionary<string, Pet>();


Endereco endErika = new Endereco("Rua Luiza Vale", 171, "", "Del Castilho", "Rio de Janeiro", "RJ");
Dono erika = new Dono("Érika", "12140251709", endErika);
Pet pipoca = new Pet("Pipoca", 2, "Yorkie", 8, erika);
petDono.Add(erika.CPF, erika);
void ExibirLogo()
{
    Console.WriteLine(@"
████████████████████████████████████████████
██▀▄─██▄─▄▄─█▄─▄▄─█▀▀▀▀▀██▄─▄▄─█▄─▄▄─█─▄─▄─█
██─▀─███─▄▄▄██─▄▄▄█████████─▄▄▄██─▄█▀███─███
▀▄▄▀▄▄▀▄▄▄▀▀▀▄▄▄▀▀▀▀▀▀▀▀▀▀▄▄▄▀▀▀▄▄▄▄▄▀▀▄▄▄▀▀");
    Console.WriteLine("\n\n\n");
}

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar Pet Parent");
    Console.WriteLine("Digite 2 para registrar o Pet");
    Console.WriteLine("Digite 3 para Registrar um médico veterinário");
    Console.WriteLine("Digite 4 para agendar consulta");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarDonoDoPet();
            break;
        case 2:
            RegistrarPet();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}



void RegistrarDonoDoPet()
{

    Console.WriteLine("Informe o CPF do dono.");
    var cpfDono = Console.ReadLine();
    if (petDono.ContainsKey(cpfDono))
    {
        Console.WriteLine($"Dono com CPF {cpfDono} já está cadastrado.");
        Thread.Sleep(2000);
        Console.Clear();
        MenuInicial();
    }

    else
    {
        //Dono newDono = new Dono(docDono);
        Console.WriteLine("Digite o nome do Pet Parent (Dono do pet):");
        var nomeDono = Console.ReadLine();
        Console.WriteLine("\nAgora vamos realizar o cadastro do endereço...");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("Digite o nome da rua do Pet parent:");
        var ruaDono = Console.ReadLine();
        Console.WriteLine("\nDigite o número da residência:");
        var numeroResidenciaDono = Console.ReadLine();
        Console.WriteLine("\nTem complemento? (s/n)");
        var compDono = Console.ReadLine();

        if (compDono == "S" || compDono == "s")
        {
            Console.WriteLine("\nInforme o complemento:");
            var complementoDono = Console.ReadLine();
        }
        else
        {
            string complementoDono = null;
        }
        Console.WriteLine("\nDigite o bairro da residência:");
        var bairroDono = Console.ReadLine();
        Console.WriteLine("\nDigite a cidade da residência:");
        var cidadeDono = Console.ReadLine();
        Console.WriteLine("\nDigite a UF da residência:");
        var ufDono = Console.ReadLine();

        var preencherEnderecoDono = new Endereco(ruaDono, int.Parse(numeroResidenciaDono), compDono, bairroDono, cidadeDono, ufDono);
        var preencherDono = new Dono(nomeDono, cpfDono, preencherEnderecoDono);

        petDono.Add(preencherDono.CPF, preencherDono);
        Console.Clear();
        MenuInicial();
    }



}

void RegistrarPet()
{

    Console.WriteLine("Informe o nome do Pet: ");
    var nomePet = Console.ReadLine();
    Console.WriteLine("Informe o CPF do Pet Parent");
    var docDono = Console.ReadLine();
    Dono donoPet = petDono[docDono];
    if (petAnimal.ContainsKey(docDono) && petAnimal.ContainsKey(nomePet)) //Corrigir essa validação, acredito que não seja containskey
    {
        
            Console.WriteLine("Informe o SKU: ");
            var sku = Console.ReadLine();
            if (petAnimal.ContainsKey(sku))
            {
                Console.WriteLine("Não é possível concluir o cadastro. \nPet e Dono já estão relacionados em um mesmo cadastro existente");
            }
        

    }
    else
    {
        Console.WriteLine("Digite a raça do Pet: ");
        var racaPet = Console.ReadLine();
        Console.WriteLine("Informe a idade do Pet: ");
        var idadePet = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o peso do Pet?");
        var pesoPet = double.Parse(Console.ReadLine());

        Pet petRegistro = new Pet(nomePet, idadePet, racaPet, pesoPet, donoPet);
        petAnimal.Add(petRegistro.SKUPET.ToString(), petRegistro);
        Console.Clear();
        MenuInicial();
    }
}

void MenuInicial()
{
    ExibirLogo();
    ExibirMenu();

}

MenuInicial();
