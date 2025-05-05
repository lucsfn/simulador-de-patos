public class RedHatDuck : Duck, IFlyable, IQuackable
{
    public RedHatDuck(string name, int age, string color, double size) : base(name, age, color, size)
    {}

    public void Fly ()
    {
        Console.WriteLine($"O {getName()} está voando!");
    }

    public void Quack()
    {
        Console.WriteLine($"O {getName()} está grasnando!");
    }
}