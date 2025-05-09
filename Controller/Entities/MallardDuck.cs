public class MallardDuck : Duck, IFlyable, IQuackable
{
    public MallardDuck(string name, int age, string color, double size) : base(name, age, color, size) { }

    public void Quack()
    {
        Console.WriteLine($"\n🦆 {getName()} faz: Quack! Quack! de forma estridente!");
    }

    public bool CanFly()
    {
        return true;
    }

    public void Fly()
    {
        Console.WriteLine($"\n🦅 {getName()} está voando majestosamente pelo ar!");
    }

    public override void Display()
    {
        Console.WriteLine($"Eu sou um Marreco chamado {getName()}!");
        base.Display();
    }
}