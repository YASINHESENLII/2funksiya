internal class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 1, 2, 5, 4, 5 };
        int value = 5;
        Func(ints, value);
    }

    public static int Func(int[] ints, int value)
    {
        int number = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] == value)
            {
                number++;
            }
        }
        Console.WriteLine(number);
        return number;
    }
}
