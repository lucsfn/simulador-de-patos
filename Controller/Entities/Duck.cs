public abstract class Duck
{
    protected string _name = string.Empty;
    protected int _age = 0;
    protected string _color = string.Empty;
    protected double _size = 0;

    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("O nome não pode ser nulo ou vazio.");
        }
        else _name = name;
    }

    public void setAge(int age)
    {
        if (age < 0 || age > 100)
        {
            throw new ArgumentOutOfRangeException("A idade deve ser um número válido entre 0 e 100.");
        }
        else _age = age;
    }

    public void setColor(string color)
    {
        if (string.IsNullOrEmpty(color))
        {
            throw new ArgumentException("A cor não pode ser nula ou vazia.");
        }
        else _color = color;
    }

    public void setSize(double size)
    {
        if (size <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(size), "O tamanho deve ser um número positivo.");
        }
        else _size = size;
    }

    public string getName()
    {
        return _name;
    }

    public int getAge()
    {
        return _age;
    }

    public string getColor()
    {
        return _color;
    }

    public double getSize()
    {
        return _size;
    }

    public Duck(string name, int age, string color, double size)
    {
        setName(name);
        setAge(age);
        setColor(color);
        setSize(size);
    }

    public virtual void Display()
    {
        Console.WriteLine($"Nome: {getName()}, Idade: {getAge()} anos, Cor: {getColor()}, Tamanho: {getSize()} centímetros.");
    }
}