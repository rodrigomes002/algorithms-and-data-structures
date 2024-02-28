namespace Algoritmos.beecrowed;

public class _1078
{
    public static void Tabuada()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {n} = {n * i}");
        }
    }
}
