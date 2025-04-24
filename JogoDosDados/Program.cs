namespace JogoDosDados;

internal class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        while (true)
        {
            Menu menu = new Menu();
            LancadorDados lancadorDados = new LancadorDados();

            Jogador usuario = new Jogador("Usuário");

            Jogador computador = new Jogador("Computador");

            Jogador[] jogadores = [usuario, computador];

            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                foreach (var jogador in jogadores)
                {
                    menu.ExibirCabecalho(jogador.nome);

                    int resultado = lancadorDados.Sortear();

                    menu.ExibirResultadoSorteio(resultado);

                    jogador.AvancarPosicao(resultado);

                    menu.ExibirPosicaoJogador(limiteLinhaChegada, jogador.posicao);

                    if (jogador.EstaNaPosicaoAvancoEspecial())
                    {
                        menu.ExibirMensagemAvancoEspecial();

                        jogador.AvancarPosicaoEspecial();

                        menu.ExibirPosicaoAvancoEspecial(jogador.posicao);
                    }
                    else if (jogador.EstaNaPosicaoRecuoEspecial())
                    {
                        menu.ExibirMensagemRecuoEspecial();

                        jogador.RecuarPosicaoEspecial();

                        menu.ExibirPosicaoRecuoEspecial(jogador.posicao);
                    }

                    if (jogador.UltrapassouLinhaChegada(limiteLinhaChegada))
                    {
                        menu.ExibirMensagemVitoria(jogador.nome);

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.ReadLine();
                }
            }

            Console.Write("Deseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }

    }
}
