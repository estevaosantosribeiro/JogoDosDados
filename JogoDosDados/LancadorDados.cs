namespace JogoDosDados;

public class LancadorDados
{
    public int Sortear()
    {
        Random geradorDeNumeros = new Random();

        int resultado = geradorDeNumeros.Next(1, 7);

        return resultado;
    }

}
