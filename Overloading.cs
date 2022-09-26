namespace PolymorphismDemo;
public class OverloadingExample
{
    public int Add(int A, int B)
    {
        return A + B;
    }

    public int Add(int A, int B, int C)
    {
        return A + B + C;
    }

    public int Add(int A, int B, int C, int E)
    {
        return A + B + C + E;
    }
}
class Program
{
    static void Main(string[] args)
    {
        OverloadingExample dataClass = 
            new OverloadingExample();

        int add1 = dataClass.Add(23, 34);
        int add2 = dataClass.Add(45, 34, 67);
        int add3 = dataClass.Add(45, 34, 67, 55);
    }
}

