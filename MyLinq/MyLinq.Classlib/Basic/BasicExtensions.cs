namespace MyLinq.Classlib.Basic;

// Extension methods
public static class BasicExtensions
{
    public static int Add(this int a, int b) => a + b;
    public static void Print(this Human h) => Console.WriteLine(h.Greet());
}
