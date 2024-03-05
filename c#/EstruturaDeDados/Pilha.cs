namespace EstruturaDeDados;
public class Pilha
{
    private string[] Itens;
    private int Topo;

    public Pilha(int capacidade)
    {
        Itens = new string[capacidade];
        Topo = -1;
    }

    public void Push(string item)
    {
        if (Topo == Itens.Length - 1)
            throw new InvalidOperationException("Pilha cheia");

        Topo++;
        Itens[Topo] = item;
    }

    public string Pop()
    {
        if (EstaVazia())
            throw new InvalidOperationException("Pilha vazia");

        string item = Itens[Topo];
        Topo--;
        return item;
    }

    public string Peek()
    {
        if (EstaVazia())
            throw new InvalidOperationException("Pilha vazia");

        return Itens[Topo];
    }

    public bool EstaVazia()
    {
        return Topo == -1;
    }
}