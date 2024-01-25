namespace Algoritmos.beecrowed
{
    public class _1061
    {
        public static void TempoDeUmEvento()
        {
            string diaInicio = Console.ReadLine()!.Split(' ')[1];
            string horaInicio = Console.ReadLine()!;
            string diaFim = Console.ReadLine()!.Split(' ')[1];
            string horaFim = Console.ReadLine()!;

            DateTime dataInicio = DateTime.Parse($"2023-04-{diaInicio} {horaInicio}");
            DateTime dataFim = DateTime.Parse($"2023-04-{diaFim} {horaFim}");

            TimeSpan duracao = dataFim - dataInicio;

            int dias = duracao.Days;
            int horas = duracao.Hours;
            int minutos = duracao.Minutes;
            int segundos = duracao.Seconds;

            Console.WriteLine($"{dias} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");
        }
    }
}
