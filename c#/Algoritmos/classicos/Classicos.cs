namespace algoritmos.classicos
{
    public class Classicos
    {
        public static int Fatorial(int n)
        {
            int res;

            if (n == 0 || n == 1)
                res = 1;
            else
                res = n * Fatorial(n - 1);

            return res;
        }

        public static int Menor(int[] arr, int n)
        {
            int menor = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < menor)
                    menor = arr[i];
            }

            return menor;
        }
    }
}