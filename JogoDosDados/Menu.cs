namespace JogoDosDados;

public class Menu
{
    public void ExibirCabecalho(string nome)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Rodada do {nome}");
        Console.WriteLine("--------------------------------------");
        Console.Write("Pressione ENTER para lançar o dado...");
        Console.ReadLine();
    }
    public void ExibirResultadoSorteio(int resultadoJogador)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"O valor sorteado foi: {resultadoJogador}!");
        Console.WriteLine("--------------------------------------");
    }
    public void ExibirPosicaoJogador(int limiteLinhaChegada, int posicaoUsuario)
    {
        Console.WriteLine($"O jogador está na posição {posicaoUsuario} de {limiteLinhaChegada}");
    }
    public void ExibirPosicaoAvancoEspecial(int posicaoUsuario)
    {
        Console.WriteLine($"O jogador avançou para a posição: {posicaoUsuario}!");
        Console.WriteLine("--------------------------------------");
    }

    public void ExibirMensagemAvancoEspecial()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");
    }
    public void ExibirPosicaoRecuoEspecial(int posicaoUsuario)
    {
        Console.WriteLine($"O jogador recuou para a posição: {posicaoUsuario}!");
        Console.WriteLine("--------------------------------------");
    }

    public void ExibirMensagemRecuoEspecial()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");
    }

    public void ExibirMensagemVitoria(string nome)
    {
        Console.WriteLine($"Parabéns! {nome} alcançou a linha de chegada!");
    }
}
