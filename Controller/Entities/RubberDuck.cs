public class RubberDuck : Duck, IQuackable
{
    private double _price;
    private string _material = string.Empty;

    public void setPrice(double price)
    {
        if (price < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "O preço deve ser um número positivo.");
        }
        else _price = price;
    }

    public void setMaterial(string material)
    {
        if (string.IsNullOrEmpty(material))
        {
            throw new ArgumentException("O material não pode ser nulo ou vazio.");
        }
        else _material = material;
    }

    public double getPrice()
    {
        return _price;
    }

    public string getMaterial()
    {
        return _material;
    }

    public RubberDuck(string name, int age, string color, double size, double price, string material) : base(name, age, color, size)
    {
        setPrice(price);
        setMaterial(material);
    }

    public void Quack()
    {
        Console.WriteLine($"O {getName()} está grasnando!");
    }
}