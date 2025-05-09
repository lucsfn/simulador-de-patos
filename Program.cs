public class Program
{
    public static void Main()
    {
        MallardDuck marreco = new MallardDuck("Marreco", 2, "verde", 40);
        marreco.Display();
        marreco.Fly();
        marreco.Quack();

        RedHatDuck patoDeChapeuVermelho = new RedHatDuck("Pato de chapéu vermelho", 3, "vermelho", 20);
        patoDeChapeuVermelho.Display();
        patoDeChapeuVermelho.Fly();

        RubberDuck patoDeBorracha = new RubberDuck("Pato de borracha", 1, "amarelo", 4 , 10.5, "borracha");
        patoDeBorracha.Display();
        patoDeBorracha.Quack();
    }
}