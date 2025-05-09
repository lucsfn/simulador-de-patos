public static class Menu {
    public static string Option = "initial";
    public static void displayInitialMenu() {
        Console.WriteLine("=========================\n");
        Console.WriteLine("Bem vindo ao Simulador de Patos!\n");
        Console.WriteLine("=========================\n");
        Console.WriteLine("Gostaria de ver a lista de patos disponíveis?\n");
        Console.WriteLine("Digite [Qualquer tecla] - para Sim");
        Console.WriteLine("Digite [0] - para Não");
        Console.WriteLine("=========================\n");
        Option = Console.ReadLine()!;
        validateOptionIfEmpty();
        // TODO implementar método para listar os patos disponíveis
        
    }

    public static void validateOptionIfEmpty() {
        do
        {
            if (Option == string.Empty)
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                Option = Console.ReadLine()!;
            }

        } while (Option == string.Empty);
    }
}