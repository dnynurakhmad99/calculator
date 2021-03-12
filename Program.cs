class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Calculator";

        int a = 5;
        int b = 5;

        Console.WriteLine(Penambahan(a, b));
        Console.WriteLine(Pengurangan(a, b));
        Console.WriteLine(Perkalian(a, b));
        Console.WriteLine(Pembagian(a, b));
    }

    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    static int Pengurangan(int a, int b)
    {
        return a - b;
    }

        static int Perkalian(int a, int b)
    {
        return a * b;
    }

	static int Pembagian(int a, int b)
    {
        return a / b;
    }
}
