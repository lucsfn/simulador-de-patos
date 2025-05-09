public class MallardDuck : Duck, IFlyable, IQuackable
{
    public MallardDuck(string name, int age, string color, double size) : base(name, age, color, size)
    {
        setName(name);
        setAge(age);
        setColor(color);
        setSize(size);
    }

    public void Fly()
    {
        Console.WriteLine($"O {getName()} está voando!");
    }

    public void Quack()
    {
        Console.WriteLine($"O {getName()} está grasnando!");
    }
}