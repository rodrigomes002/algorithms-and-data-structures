namespace algoritmos.beecrowed.rodrigo
{
    public class _1047
    {
        public static void DuracaoEmHorasEMinutos()
        {
            string[] entrada = Console.ReadLine()!.Split(' ');

            int horaInicial = Convert.ToInt32(entrada[0]);
            int minutoInicial = Convert.ToInt32(entrada[1]);

            int horaFinal = Convert.ToInt32(entrada[2]);
            int minutoFinal = Convert.ToInt32(entrada[3]);

            int duracaoHoras, duracaoMinutos;
            int minutosInicial = horaInicial * 60 + minutoInicial;
            int minutosFinal = horaFinal * 60 + minutoFinal;

            if (minutosInicial < minutosFinal)
            {
                int duracaoMinutosTotal = minutosFinal - minutosInicial;
                duracaoHoras = duracaoMinutosTotal / 60;
                duracaoMinutos = duracaoMinutosTotal % 60;
            }
            else
            {
                int duracaoMinutosTotal = (24 * 60 - minutosInicial) + minutosFinal;
                duracaoHoras = duracaoMinutosTotal / 60;
                duracaoMinutos = duracaoMinutosTotal % 60;
            }


            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");
        }
    }
}
