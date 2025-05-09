public class GameView
{
    private DuckController? _duckController;

    public void StartGame()
    {
        Menu.displayInitialMenu();
    }

    public void CreateDuck(int duckType)
    {
        try
        {
            _duckController = new DuckController(duckType);
            DisplayDuckActionMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ Erro: {ex.Message}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu.displayDuckList();
        }
    }

    public void DisplayDuckActionMenu()
    {
        if (_duckController == null || _duckController.duck == null)
        {
            Console.WriteLine("\n❌ Nenhum pato selecionado. Retornando ao menu principal...");
            Menu.displayInitialMenu();
            return;
        }

        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.Clear();
            Console.WriteLine("=========================\n");
            Console.WriteLine($"🦆 O que deseja fazer com o pato {_duckController.duck.getName()}?\n");
            Console.WriteLine("1. 📋 Mostrar detalhes");
            Console.WriteLine("2. 🔊 Fazer grasnar");
            Console.WriteLine("3. ✈️ Tentar fazer voar");
            Console.WriteLine("4. ↩️ Voltar à lista de patos");
            Console.WriteLine("0. 🏠 Voltar ao menu inicial");
            Console.WriteLine("=========================\n");

            string option = Console.ReadLine()!;
            Validate.validatedataIfEmpty(option);
            Validate.validateInputNumber(option);

            switch (option)
            {
                case "1":
                    _duckController.displayDuckDetails(_duckController.duck);
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("=========================\n");
                    if (_duckController.duck is IQuackable quackable)
                    {
                        quackable.Quack();
                    }
                    else
                    {
                        Console.WriteLine($"\n❌ {_duckController.duck.getName()} não pode grasnar!");
                    }
                    Console.WriteLine("\n=========================");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("=========================\n");
                    if (_duckController.duck is IFlyable flyable)
                    {
                        if (flyable.CanFly())
                        {
                            flyable.Fly();
                        }
                        else
                        {
                            Console.WriteLine($"\n❌ {_duckController.duck.getName()} não consegue voar no momento.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\n❌ {_duckController.duck.getName()} não pode voar. Este tipo de pato não tem essa habilidade.");
                    }
                    Console.WriteLine("\n=========================");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "4":
                    exitMenu = true;
                    Menu.displayDuckList();
                    break;
                case "0":
                    exitMenu = true;
                    Menu.displayInitialMenu();
                    break;
                default:
                    Console.WriteLine("\n❌ Opção inválida! Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}