namespace Algoritmos.beecrowed
{
    public class _1049
    {
        public static void Animal()
        {
            string entrada1 = Console.ReadLine()!;
            string entrada2 = Console.ReadLine()!;
            string entrada3 = Console.ReadLine()!;

            if (entrada1 == "vertebrado")
            {
                if (entrada2 == "ave")
                {
                    if (entrada3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }

                    if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }

                if (entrada2 == "mamifero")
                {
                    if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }

                    if (entrada3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            if (entrada1 == "invertebrado")
            {
                if (entrada2 == "inseto")
                {
                    if (entrada3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }

                    if (entrada3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }

                if (entrada2 == "anelideo")
                {
                    if (entrada3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }

                    if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
