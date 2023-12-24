using Exercicio2_PetShop.Cliente;
using Exercicio2_PetShop.Endereco;

Endereco endErika = new Endereco("Rua Luiza Vale", 171, "", "Del Castilho", "Rio de Janeiro", "RJ");
Dono erika = new Dono("Érika", "12140251709", endErika);
Pet pipoca = new Pet("Pipoca", 2, "Yorkie", 8,erika);

