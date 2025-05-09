public static class Validate
{
    public static void validatedataIfEmpty(string data)
    {
        while (string.IsNullOrWhiteSpace(data))
        {
            Console.WriteLine("\nEntrada não pode ser vazia! Tente novamente:");
            data = Console.ReadLine()!;
        }
    }

    public static void validateInputNumber(string data)
    {
        bool isValid = false;

        do
        {
            isValid = int.TryParse(data, out int result);

            if (!isValid)
            {
                Console.WriteLine("\nEntrada inválida! Por favor, digite um número válido:");
                data = Console.ReadLine()!;
                validatedataIfEmpty(data);
            }

        } while (!isValid);
    }
}