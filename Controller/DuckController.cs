public class DuckController
{
    public Duck duck;

    public Duck(int duckType)
    {
        switch (duckType)
        {
            case 1:
                duck = new MallardDuck();
                break;
            case 2:
                duck = new RedHatDuck();
                break;
            case 3:
                duck = new RubberDuck();
                break;
            default:
                throw new ArgumentException("Tipo de pato inválido");
        }
    }

    public static void displayDuckDetails()
    {
        
    }
}