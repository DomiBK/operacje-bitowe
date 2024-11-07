class BitOperations
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Liczba bitów ustawionych na 1:");
        Console.WriteLine(CountSetBits(5)); // Wynik: 2

        Console.WriteLine("\nSprawdzenie, czy liczba jest potęgą 2:");
        Console.WriteLine(IsPowerOfTwo(8)); // Wynik: True
        Console.WriteLine(IsPowerOfTwo(10)); // Wynik: False

        Console.WriteLine("\nOdbijanie bitów:");
        Console.WriteLine(Convert.ToString(ReverseBits(3), 2).PadLeft(sizeof(int) * 8, '0')); // Wynik: 11000000

        Console.WriteLine("\nPrzełączanie bitu (Toggle):");
        Console.WriteLine(Convert.ToString(ToggleBit(5, 1), 2).PadLeft(sizeof(int) * 8, '0')); // Wynik: 01110001
    }

    public static int CountSetBits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count += number & 1;
            number >>= 1;
        }
        return count;
    }

    public static bool IsPowerOfTwo(int number)
    {
        return number > 0 && (number & (number - 1)) == 0;
    }

    public static int ReverseBits(int number)
    {
        int result = 0;
        for (int i = 0; i < sizeof(int) * 8; i++)
        {
            result <<= 1;
            result |= number & 1;
            number >>= 1;
        }
        return result;
    }

    public static int ToggleBit(int number, int position)
    {
        return number ^ (1 << position);
    }
}
