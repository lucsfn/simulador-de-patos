public static class Menu
{
    public static string Option = "initial";
    private static GameView _gameView = new GameView();

    public static void displayInitialMenu()
    {
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine("🦆 Bem vindo ao Simulador de Patos! 🦆\n");
        Console.WriteLine("=========================\n");
        Console.WriteLine("Gostaria de ver a lista de patos disponíveis?\n");
        Console.WriteLine("Digite [Qualquer tecla] - para Sim");
        Console.WriteLine("Digite [0] - para Não");
        Console.WriteLine("=========================\n");
        Option = Console.ReadLine()!;
        Validate.validatedataIfEmpty(Option);
        if (Option != "0")
        {
            displayDuckList();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("=========================\n");
            Console.WriteLine("🙏 Obrigado por usar o Simulador de Patos!\n");
            Console.WriteLine("=========================\n");
            Console.ReadLine();
            Console.Clear();
        }
    }

    public static void displayDuckList()
    {
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine("🦆 Lista de Patos Disponíveis: 🦆\n");
        Console.WriteLine("1. 🦅 Marreco");
        Console.WriteLine("2. 🎩 Pato de chapéu vermelho");
        Console.WriteLine("3. 🛁 Pato de borracha");
        Console.WriteLine("0. 🏠 Voltar ao menu inicial\n");
        Console.WriteLine("=========================\n");
        Console.WriteLine("Digite o número do pato para ver suas habilidades, ou C + número para criar (ex: C1):\n");
        Option = Console.ReadLine()!;
        Validate.validatedataIfEmpty(Option);

        if (Option.StartsWith("C", StringComparison.OrdinalIgnoreCase) && Option.Length > 1)
        {
            string duckNumber = Option.Substring(1);
            if (int.TryParse(duckNumber, out int duckType) && duckType >= 1 && duckType <= 3)
            {
                _gameView.CreateDuck(duckType);
            }
            else
            {
                Console.WriteLine("\n❌ Opção inválida! Tente novamente.");
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                displayDuckList();
            }
        }
        else if (Option == "0")
        {
            displayInitialMenu();
        }
        else if (int.TryParse(Option, out int duckType) && duckType >= 1 && duckType <= 3)
        {
            displayDuckAbilities(duckType);
        }
        else
        {
            Console.WriteLine("\n❌ Opção inválida! Tente novamente.");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            displayDuckList();
        }
    }

    public static void displayDuckAbilities(int duckType)
    {
        Console.Clear();
        Console.WriteLine("=========================\n");

        string duckName = "";
        string abilities = "";
        string emoji = "";

        switch (duckType)
        {
            case 1:
                duckName = "Marreco";
                emoji = "🦅";
                abilities = "- 🔊 Pode grasnar (Quack! Quack!)\n- ✈️ Pode voar";
                break;
            case 2:
                duckName = "Pato de chapéu vermelho";
                emoji = "🎩";
                abilities = "- 🔊 Pode grasnar com elegância\n- ✈️ Pode voar com estilo usando seu chapéu";
                break;
            case 3:
                duckName = "Pato de borracha";
                emoji = "🛁";
                abilities = "- 🔊 Faz barulho de borracha (Squeak! Squeak!)\n- ❌ Não pode voar";
                break;
        }

        Console.WriteLine($"{emoji} Habilidades do {duckName}: {emoji}\n");
        Console.WriteLine(abilities);
        Console.WriteLine("\n=========================\n");
        Console.WriteLine("1. ✅ Criar este pato");
        Console.WriteLine("0. ↩️ Voltar à lista de patos");
        Console.WriteLine("=========================\n");

        string choice = Console.ReadLine()!;
        Validate.validatedataIfEmpty(choice);

        switch (choice)
        {
            case "1":
                _gameView.CreateDuck(duckType);
                break;
            case "0":
            default:
                displayDuckList();
                break;
        }
    }
}