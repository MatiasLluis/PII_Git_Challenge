Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));

// Esta clse implementa la operacion suma
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

//Esta clase implementa la operacion suma
public class Addition
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
// Esta clase implementa la operación resta
public class Substraction
{
    public static int Substract(int a, int b)
    {
        return a - b;
    }
}