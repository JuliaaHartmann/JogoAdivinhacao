// Objetivos / Passo-a-passo

//v1
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um número secreto aleatório
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem
// 4. Nosso jogo deve permitir múltiplas tentativas

// v2
// 1. Nosso jogo deve implementar a funcionalidade de dificuldade e tentavias limitadas

using System;

//Eu quero usar a biblioteca padrão do Sistema relacionada a criptografia
using System.Security.Cryptography; 

while (true == true)
{
    Console.Clear();

    Console.WriteLine("---------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Escola o nível de dificuldade:");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Médio (5 tentativas)");
    Console.WriteLine("3 - Difícil (3 tentativas)");
    Console.WriteLine("---------------------------------");

    Console.Write("Digite sua escolha: ");
    string? dificuldade = Console.ReadLine();

    int numeroMaximo = 0;
    int tentativasMaximas;

    switch (dificuldade)
    {
        case "1":
            numeroMaximo = 20;
            tentativasMaximas = 10;
            break;

        case "2":
            numeroMaximo = 50;
            tentativasMaximas = 5;
            break;

        case "3":
            numeroMaximo = 100;
            tentativasMaximas = 3;
            break;

        default: 
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Por favor, selecione uma dificuldade válida. ");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
            continue;
    }

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, numeroMaximo + 1);

    for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Tentativa {tentativa} de {tentativasMaximas}.");
        Console.WriteLine("---------------------------------");

        Console.Write($"Digite um número entre 1 e {numeroMaximo}: ");
       
        string? chute = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(chute); 

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Parabéns! Você acertou!");
            Console.WriteLine("---------------------------------");

            break;
        }
        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("O número digitado foi maior que o número secreto");
            Console.WriteLine("---------------------------------");
        }
        else
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("O número digitado foi menor que o número secreto!");
            Console.WriteLine("---------------------------------");
        }

        if (tentativa == tentativasMaximas)
        {
            Console.WriteLine($"Você usou todas as suas tentativas! O número era {numeroAleatorio}.");
            Console.WriteLine("---------------------------------");
            break;
        }

         Console.ReadLine();

    }    

    Console.Write("Deseja continuar? (S/N): ");
    string? opcaoContinuar = Console.ReadLine(); // nullable

    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }
}