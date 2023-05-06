namespace Algoritmos.beecrowed.rodrigo
{
    public class _1052
    {
        public static void Mes()
        {
            int mes = int.Parse(Console.ReadLine());
            string saida = string.Empty;

            switch (mes)
            {
                case 1:
                    saida = "January";
                    break;
                case 2:
                    saida = "February";
                    break;
                case 3:
                    saida = "March";
                    break;
                case 4:
                    saida = "April";
                    break;
                case 5:
                    saida = "May";
                    break;
                case 6:
                    saida = "June";
                    break;
                case 7:
                    saida = "July";
                    break;
                case 8:
                    saida = "August";
                    break;
                case 9:
                    saida = "September";
                    break;
                case 10:
                    saida = "October";
                    break;
                case 11:
                    saida = "November";
                    break;
                case 12:
                    saida = "December";
                    break;
            }

            Console.WriteLine(saida);
        }
    }
}
