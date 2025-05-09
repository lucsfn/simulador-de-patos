public static class Validate {
        public static void validatedataIfEmpty(string data) {
        do
        {
            if (data == string.Empty)
            {
                Console.WriteLine("\nOpção inválida! Tente novamente.");
                data = Console.ReadLine()!;
            }

        } while (data == string.Empty);
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