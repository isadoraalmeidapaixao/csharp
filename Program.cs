using System;
using Petshop2;

class Program
{
    static Animal[] animais = new Animal[0]; // Começa vazio

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("1 - Cadastrar Animal");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Atender Animal");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opcao == 1)
            {
                CadastrarAnimal();
            }
            else if (opcao == 2)
            {
                ListarAnimais();
            }
            else if (opcao == 3)
            {
                Atender();
            }

        } while (opcao != 4); // só sai quando escolher 4
    }

    static void CadastrarAnimal()
    {
        Console.Write("\nDigite o nome do animal: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade do animal: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o tipo do animal:");
        Console.WriteLine("1 - Cachorro");
        Console.WriteLine("2 - Gato");
        Console.Write("Opção: ");
        int especie = int.Parse(Console.ReadLine());


        // Exemplo: sempre cria um gato
        Animal novoAnimal;

        if (especie == 1)
        {
            novoAnimal = new Cachorro(nome, idade);
        }
        else
        {
            novoAnimal = new Gato(nome, idade);
        }

        Animal[] novoArray = new Animal[animais.Length + 1];

        for (int i = 0; i < animais.Length; i++)
        {
            novoArray[i] = animais[i];
        }

        novoArray[novoArray.Length - 1] = novoAnimal;
        animais = novoArray;


        Console.WriteLine("✅ Animal cadastrado com sucesso!");
    }

    static void ListarAnimais()
    {
        Console.WriteLine("\nLista de Animais:");

        if (animais.Length == 0)
        {
            Console.WriteLine("Nenhum animal cadastrado.");
            return;
        }

        for (int i = 0; i < animais.Length; i++)
        {
            Console.WriteLine($"Nome: {animais[i].nome}, Idade: {animais[i].novaIdade}");
        }
    }

    static void Atender()
    {
        Console.Write("\nDigite o nome do animal a ser atendido: ");
        string nome = Console.ReadLine();

        Animal animalParaAtender = null;

        for (int i = 0; i < animais.Length; i++)
        {
            if (animais[i].nome == nome)
            {
                animalParaAtender = animais[i];
                break;
            }
        }

        if (animalParaAtender != null)
        {
            animalParaAtender.Atender();
        }
        else
        {
            Console.WriteLine("❌ Animal não encontrado!");
        }
    }
}
