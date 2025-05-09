public class RubberDuck : Duck, IQuackable
{
    public RubberDuck(string name, int age, string color, double size) : base(name, age, color, size)
    {
        setName(name);
        setAge(age);
        setColor(color);
        setSize(size);
    }

    public void Quack()
    {
        Console.WriteLine($"O {getName()} está grasnando!");
    }
}