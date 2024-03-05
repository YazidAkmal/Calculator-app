class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
        int b = 6;
		
		Console.WriteLine("Hasil Penambagan: {0} + {1}", a, b, Penambahan(a,b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1}", a, b, Pengurangan(a,b));
		
		Console.WriteLine("\nTekan Apa saja");
		Console.ReadKey();
	}
	static int Penambahan(int a, int b) 
    {
		return a + b; 
    }
	static int Pengurangan(int a, int b)
    {
        return a - b;
    }
}