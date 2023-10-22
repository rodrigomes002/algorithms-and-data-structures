namespace algoritmos.classicos
{
    public class Classicos
    {
        public static int Fatorial(int n)
        {
            int res;
            
            if(n == 0 || n == 1)
                res = 1;
            else
                res = n * Fatorial(n-1);
            
            return res;
        }
    }
}