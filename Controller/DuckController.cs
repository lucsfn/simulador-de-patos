public class DuckController
{
    public Duck duck;

    public DuckController(int duckType)
    {
        // Primeiro coletamos os dados do pato antes de criar a instância
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine("🦆 Configure seu pato: 🦆\n");

        Console.WriteLine("Digite o nome do pato:");
        string name = Console.ReadLine()!;
        Validate.validatedataIfEmpty(name);

        Console.WriteLine("Digite a idade do pato:");
        string ageInput = Console.ReadLine()!;
        Validate.validatedataIfEmpty(ageInput);
        Validate.validateInputNumber(ageInput);
        int age = int.Parse(ageInput);

        Console.WriteLine("Digite a cor do pato:");
        string color = Console.ReadLine()!;
        Validate.validatedataIfEmpty(color);

        Console.WriteLine("Digite o tamanho do pato (em cm):");
        string sizeInput = Console.ReadLine()!;
        Validate.validatedataIfEmpty(sizeInput);
        Validate.validateInputNumber(sizeInput);
        double size = double.Parse(sizeInput);

        // Agora criamos a instância com os valores já validados
        switch (duckType)
        {
            case 1:
                duck = new MallardDuck(name, age, color, size);
                break;
            case 2:
                duck = new RedHatDuck(name, age, color, size);
                break;
            case 3:
                duck = new RubberDuck(name, age, color, size);
                break;
            default:
                throw new ArgumentException("Tipo de pato inválido");
        }

        Console.WriteLine("\n✅ Pato configurado com sucesso!");
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void displayDuckDetails(Duck duck)
    {
        Console.Clear();
        Console.WriteLine("=========================\n");
        Console.WriteLine("📋 Detalhes do Pato:\n");
        duck.Display();

        Console.WriteLine("\nHabilidades:");
        Console.WriteLine($"- 🔊 Grasnar: {(duck is IQuackable ? "Sim" : "Não")}");

        if (duck is IFlyable flyable)
        {
            Console.WriteLine($"- ✈️ Voar: {(flyable.CanFly() ? "Sim" : "Não")}");
        }
        else
        {
            Console.WriteLine("- ✈️ Voar: Não");
        }

        Console.WriteLine("=========================\n");
    }
}