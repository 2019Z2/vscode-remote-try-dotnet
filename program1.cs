using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class program1
{
    private static void Main(string[] args)
    {
        Console.Write("test");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}