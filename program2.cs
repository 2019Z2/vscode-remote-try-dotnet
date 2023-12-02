internal partial class Program
{
    private static void Main(string[] args)
    {
        int num, count = 0;
        Console.WriteLine("Enter a number between 0-255");
        num = int.Parse(Console.ReadLine());
        for (int i = 0; i < 8; i++)
        {
            count = count + (num & 1);
            num = num >> 1;
        }
        Console.WriteLine("result= " + count);
        /* will run 8 times;
        used to determine one's in a binary number by converting input + count usage */
        ;
    }
}