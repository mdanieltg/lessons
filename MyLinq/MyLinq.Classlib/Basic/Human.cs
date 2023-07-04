namespace MyLinq.Classlib.Basic;

public sealed class Human
{
    public string Name { get; init; } = null!;
    public int Age { get; init; }

    public string Greet() => $"Hola, mi nombre es {Name}, y tengo {Age} años.";
}
