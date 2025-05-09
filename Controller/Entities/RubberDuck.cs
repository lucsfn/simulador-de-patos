public class RubberDuck : Duck, IQuackable
{
    public RubberDuck(string name, int age, string color, double size) : base(name, age, color, size) { }

    public void Quack()
    {
        Console.WriteLine($"\n🛁 {getName()} faz: Squeak! Squeak! como um patinho de borracha!");
    }

    // RubberDuck não implementa IFlyable porque não pode voar

    public override void Display()
    {
        Console.WriteLine($"Eu sou um Pato de Borracha chamado {getName()}!");
        base.Display();
    }
}