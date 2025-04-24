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
            Jogador usuario = new Jogador();
            usuario.posicao = 0;

            int posicaoComputador = 0;

            bool jogoEmAndamento = true;

            while (jogoEmAndamento)
            {
                menu.ExibirCabecalho();

                int resultadoUsuario = lancadorDados.Sortear();

                menu.ExibirResultadoSorteio(resultadoUsuario);

                usuario.AvancarPosicao(resultadoUsuario);

                menu.ExibirPosicaoJogador(limiteLinhaChegada, usuario.posicao);

                if (usuario.EstaNaPosicaoAvancoEspecial())
                {
                    menu.ExibirMensagemAvancoEspecial();

                    usuario.AvancarPosicaoEspecial();

                    menu.ExibirPosicaoAvancoEspecial(usuario.posicao);
                }
                else if (usuario.EstaNaPosicaoRecuoEspecial())
                {
                    menu.ExibirMensagemRecuoEspecial();

                    usuario.RecuarPosicaoEspecial();

                    menu.ExibirPosicaoRecuoEspecial(usuario.posicao);
                }

                if (usuario.UltrapassouLinhaChegada(limiteLinhaChegada))
                {
                    menu.ExibirMensagemVitoria();

                    jogoEmAndamento = false;
                    continue;
                }

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Rodada do Computador");
                Console.WriteLine("--------------------------------------");
                Console.Write("Pressione ENTER para visualizar a rodada do computador...");
                Console.ReadLine();

                int resultadoComputador = lancadorDados.Sortear();

                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"O valor sorteado foi: {resultadoComputador}!");
                Console.WriteLine("--------------------------------------");

                posicaoComputador += resultadoComputador;

                Console.WriteLine($"O computador está na posição {posicaoComputador} de {limiteLinhaChegada}");

                if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                    posicaoComputador += 3;

                    Console.WriteLine($"O computador avançou para a posição: {posicaoComputador}!");
                    Console.WriteLine("--------------------------------------");
                }
                else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                    posicaoComputador -= 2;

                    Console.WriteLine($"O computador recuou para a posição: {posicaoComputador}!");
                    Console.WriteLine("--------------------------------------");
                }

                if (posicaoComputador >= limiteLinhaChegada)
                {
                    Console.WriteLine("Que pena! O computador alcançou a linha de chegada, tente novamente!");

                    jogoEmAndamento = false;
                    continue;
                }

                Console.ReadLine();
            }

            Console.Write("Deseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }

    }
}
