// https://fsymbols.com/pt/geradores/ (site para gerar textos em ASCII)

// --------------------------------- C# - Parte 1 - Funções --------------------------------- 

void exibir_Tracos() // void é o tipo de retorno da função, ou seja, não retorna nada
{
    Console.WriteLine("---------------------------");
}

// --------------------------------- Função para exibir o menu ---------------------------------

void exibir_menu()
{
    while (true) { // loop infinito para exibir o menu até que o usuário escolha a opção 5 
        Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Listar a banda");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Mostrar media de avaliaçoes");
    Console.WriteLine("5 - Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine()!; // ! serve para que o valor não seja nulo
    int opcao_int = int.Parse(opcao); // int.Parse converte a string para inteiro
    if (opcao_int == 1)
    {
        exibir_Tracos();
        Console.WriteLine("Escolheu a opção 1");
        exibir_Tracos();
    }
    else if (opcao_int == 2)
    {
        exibir_Tracos();
        Console.WriteLine("Escolheu a opção 2");
        exibir_Tracos();
    }
    else if (opcao_int == 3)
    {
        exibir_Tracos();
        Console.WriteLine("Escolheu a opção 3");
        exibir_Tracos();
    }
    else if (opcao_int == 4)
    {
        exibir_Tracos();
        Console.WriteLine("Escolheu a opção 4");
        exibir_Tracos();
    }
    else if (opcao_int == 5)
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
  }
}

// --------------------------------- Podemos fazer com o Switch Case ---------------------------------

void exibir_menu_switch()
{
    while (true)
    {
        Console.WriteLine("1 - Registrar uma banda");
        Console.WriteLine("2 - Listar a banda");
        Console.WriteLine("3 - Avaliar uma banda");
        Console.WriteLine("4 - Mostrar media de avaliaçoes");
        Console.WriteLine("5 - Sair");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine()!;
        int opcao_int = int.Parse(opcao);
        switch (opcao_int) // switch case para substituir o if else
        {
            case 1: // caso o usuário escolha a opção 1
                exibir_Tracos();
                Console.WriteLine("Escolheu a opção 1");
                exibir_Tracos();
                break;
            case 2:
                exibir_Tracos();
                Console.WriteLine("Escolheu a opção 2");
                exibir_Tracos();
                break;
            case 3:
                exibir_Tracos();
                Console.WriteLine("Escolheu a opção 3");
                exibir_Tracos();
                break;
            case 4:
                exibir_Tracos();
                Console.WriteLine("Escolheu a opção 4");
                exibir_Tracos();
                break;
            case 5:
                Console.WriteLine("Agradeço pela preferencia!");
                return;
            default: // caso o usuário digite um valor diferente de 1 a 5
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}


// --------------------------------- C# - Parte 2: Usando variáveis e concatenando strings --------------------------------- 

string cursoAlura = "Bem vindo ao OnlineMusic"; // variável do tipo string 


// Esse @ serve para que o texto seja exibido exatamente como está escrito 
Console.WriteLine(@"
╔═╗────╔╗─────╔═╦═╗─╔═╦╗
║║╠═╦╦╗╠╬═╦╦═╗║║║║╠╦╣═╬╬═╦╦╗
║║║║║║╚╣║║║║╩╣║║║║║║╠═║║═╬║╣
╚═╩╩═╩═╩╩╩═╩═╝╚╩═╩╩═╩═╩╩═╩╩╝
");

exibir_Tracos(); // chamada da função exibir_Tracos

Console.WriteLine(cursoAlura); // exibe o valor da variável cursoAlura 

exibir_Tracos();

string primeiroNome = "Luis";
string sobrenome = "Gustavo";

Console.WriteLine("By: " + primeiroNome + " " + sobrenome); // concatenação de strings

exibir_Tracos();
exibir_menu_switch();
exibir_Tracos();


