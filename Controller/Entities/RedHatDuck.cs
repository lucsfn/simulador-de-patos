public class RedHatDuck : Duck, IFlyable, IQuackable
{
    public RedHatDuck(string name, int age, string color, double size) : base(name, age, color, size) { }

    public void Quack()
    {
        Console.WriteLine($"\n🎩 {getName()} faz: Quack! Quack! com muita elegância!");
    }

    public bool CanFly()
    {
        return true;
    }

    public void Fly()
    {
        Console.WriteLine($"\n🎩✈️ {getName()} está voando com estilo usando seu chapéu vermelho!");
    }

    public override void Display()
    {
        Console.WriteLine($"Eu sou um Pato de Chapéu Vermelho chamado {getName()}!");
        base.Display();
    }
}