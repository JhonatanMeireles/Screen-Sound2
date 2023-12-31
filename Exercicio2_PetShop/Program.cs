using Exercicio2_PetShop.Cliente;
using Exercicio2_PetShop.Endereco;
using System.Net;
using System.Net.Http.Headers;


Dictionary<string, Dono> petDono = new Dictionary<string, Dono>();
Dictionary<string, Pet> petAnimal = new Dictionary<string, Pet>();


Endereco endErika = new Endereco("Rua Luiza Vale", 171, "", "Del Castilho", "Rio de Janeiro", "RJ");
Dono erika = new Dono("Érika", "12140251709", endErika);
Pet pipoca = new Pet("Pipoca", 2, "Yorkie", 8, erika);
petDono.Add(erika.CPF, erika);
petAnimal.Add(pipoca.Nome, pipoca);


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
    Console.WriteLine("Digite 2 para Exibir todos os Pet Parent");
    Console.WriteLine("Digite 3 para registrar o Pet");
    Console.WriteLine("Digite 4 para registrar o Pet");
    Console.WriteLine("Digite 5 para Registrar um médico veterinário");
    Console.WriteLine("Digite 6 para agendar consulta");
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
            ExibirCLientes(petDono);
            Thread.Sleep(5000);
            Console.Clear();
            MenuInicial();
            break;
        case 3:
            RegistrarPet();
            break;
        case 4:
            ExibirPets();
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
        Thread.Sleep(2500);
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
        Dono preencherDono = new Dono(nomeDono, cpfDono, preencherEnderecoDono);

        petDono.Add(preencherDono.CPF, preencherDono);
        Console.Clear();
        MenuInicial();

    }



}


static void ExibirCLientes(Dictionary<string, Dono> petDono)
{
    foreach (var cliente in petDono.Values)
    {

        Console.WriteLine($"Nome: {cliente.Nome}, Documento: {cliente.CPF}");
        ExibirEndereco(cliente);
        Console.WriteLine("\n\n");
        

    }
    
}



void RegistrarPet()
{

    Console.WriteLine("Informe o nome do Pet: ");
    var nomePet = Console.ReadLine();
    Console.WriteLine("Informe o CPF do Pet Parent");
    var docDono = Console.ReadLine();     
    bool cpfEncontrado = false;
    
        if (petDono.ContainsKey(docDono))
        {
            cpfEncontrado = true;
            //Dono donoPet = petDono[docDono];//Se não houver o dono está ocorrendo erro
            
        }
        else
        {
            Console.Clear ();
            RegistrarDonoDoPet();
        }
    
    //Pet animalpet = petAnimal[nomePet]; //Aqui está ocorrendo erro
    //var valoresPet = petAnimal.Values;
    if (petAnimal.ContainsKey(nomePet) && cpfEncontrado)
    {
        Console.WriteLine("Informe o SKU: ");
        var sku = Console.ReadLine();
        var skupet = pipoca.SKUPET;

        if (int.Parse(sku) == skupet)
        {
            Console.WriteLine("Não é possível concluir o cadastro. \nPet e Dono já estão relacionados em um mesmo cadastro existente");
            Thread.Sleep(4000);
            Console.Clear();
            MenuInicial();
        }
    }
    else
    {
        Dono donoPet = petDono[docDono];
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

void ExibirPets()
{
    foreach(var animalzinho in petAnimal.Values)
    {
        Console.WriteLine($"Nome do Pet: {animalzinho.Nome}");
        Console.WriteLine($"Raça do Pet: {animalzinho.Raca}");
        Console.WriteLine($"Idade do Pet: {animalzinho.Idade}");
        Console.WriteLine($"Dono do Pet: {animalzinho.donoDoPet.Nome}");
        Console.WriteLine($"Documento do dono do Pet: {animalzinho.donoDoPet.CPF}");
        Console.WriteLine("\n\n");
        MenuInicial();
    }
}
void MenuInicial()
{
    ExibirLogo();
    ExibirMenu();

}


MenuInicial();

static void ExibirEndereco(Dono cliente)
{
    Console.WriteLine($"Endereço:{cliente.Endereco.Rua},número: {cliente.Endereco.Numero}, bairro: {cliente.Endereco.Bairro}, cidade: {cliente.Endereco.Cidade}, UF: {cliente.Endereco.UF} ");
}