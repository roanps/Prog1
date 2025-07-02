namespace WebApplication1.Models
{
    public class JogoDaVelhaModel
    {
        public char[,] Tabuleiro { get; set; } = new char[3,3];

        public char Vencedor { get; private set; } = ' ';

        public bool VerificarVitoria()
        {
            char[,] tab = Tabuleiro;

            for (int i = 0; i < 3; i++)
                if (tab[i, 0] != ' ' && tab[i, 0] == tab[i, 1] && tab[i, 1] == tab[i, 2])
                {
                    Vencedor = tab[i, 0];
                    return true;
                }

            for (int j = 0; j < 3; j++)
                if (tab[0, j] != ' ' && tab[0, j] == tab[1, j] && tab[1, j] == tab[2, j])
                {
                    Vencedor = tab[0, j];
                    return true;
                }

            if (tab[0, 0] != ' ' && tab[0, 0] == tab[1, 1] && tab[1, 1] == tab[2, 2])
            {
                Vencedor = tab[0, 0];
                return true;
            }

            if (tab[0, 2] != ' ' && tab[0, 2] == tab[1, 1] && tab[1, 1] == tab[2, 0])
            {
                Vencedor = tab[0, 2];
                return true;
            }

            return false;
        }
    }
}
