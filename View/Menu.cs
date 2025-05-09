public static class Menu {
    public static string Option = "initial";
    public static void displayInitialMenu() {
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine("Bem vindo ao Simulador de Patos!\n");
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
            Console.WriteLine("Obrigado por usar o Simulador de Patos!\n");
            Console.WriteLine("=========================\n");
            Console.ReadLine();
            Console.Clear();        
        }
    }



    public static void displayDuckList()
    {
        // TODO implementar método para listar os patos disponíveis
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine("Lista de Patos Disponíveis:\n");
        Console.WriteLine("1. Marreco");
        Console.WriteLine("2. Pato de borracha");
        Console.WriteLine("3. Pato de chapéu vermelho\n");
        Console.WriteLine("=========================\n");
        Console.WriteLine("Digite o número do pato que você gostaria de ver, ou 0 para voltar ao menu inicial:\n");
        Option = Console.ReadLine()!;
        Validate.validateInputNumber(Option);

        switch (Option)
        {
            case "1":
                Console.WriteLine("Você escolheu o Marreco!");
                break;
            case "2":
                Console.WriteLine("Você escolheu o Pato de borracha!");
                break;
            case "3":
                Console.WriteLine("Você escolheu o Pato de chapéu vermelho!");
                break;
            case "0":
                displayInitialMenu();
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                displayDuckList();
                break;
        }
    }

    public static void displayDuckDetails(string duckType)
    {
        // TODO implementar método para exibir detalhes do pato selecionado
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine($"Detalhes do {duckType}:\n");
        Console.WriteLine("Descrição: Um pato muito especial!");
        Console.WriteLine("Preço: R$ 10,00\n");
        Console.WriteLine("=========================\n");
        Console.WriteLine("Pressione qualquer tecla para voltar à lista de patos.");
        Console.ReadKey();
        displayDuckList();
    }
}