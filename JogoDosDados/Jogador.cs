namespace JogoDosDados;

public class Jogador
{
    public int posicao;
    public string nome;

    public Jogador (string nome)
    {
        this.nome = nome;
    }

    public void AvancarPosicao(int resultadoLancamento)
    {
        posicao += resultadoLancamento;
    }

    public bool EstaNaPosicaoAvancoEspecial()
    {
        return posicao == 5 || posicao == 10 || posicao == 15 || posicao == 25;
    }

    public void AvancarPosicaoEspecial()
    {
        posicao += 3;
    }

    public bool EstaNaPosicaoRecuoEspecial()
    {
        return posicao == 7 || posicao == 13 || posicao == 20;
    }

    public void RecuarPosicaoEspecial()
    {
        posicao -= 2;
    }

    public bool UltrapassouLinhaChegada(int limiteLinhaChegada)
    {
        return posicao >= limiteLinhaChegada;
    }
}
