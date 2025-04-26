namespace JogoDaForca.ConsoleApp
{
    internal class Jogo
    {
        public string palavraSecreta = "";
        public char[] letrasChutadas;
        public char[] letrasEncontradas;

        public int qtdErros = 0;
        public int qtdTotalErros = 5;
        public int tentativa = 0;

        public bool palavraFoiEncontrada = false;

        public int IndicePalavraSorteada()
        {
            Random sorteador = new Random();
            return sorteador.Next(0, 20);
        }

        public void SortearPalavra(Categoria categoria)
        {
            if (categoria.nome == "Frutas")
            {
                palavraSecreta = categoria.frutas[IndicePalavraSorteada()];
            }
            else if (categoria.nome == "Animais")
            {
                palavraSecreta = categoria.animais[IndicePalavraSorteada()];
            }
            else if (categoria.nome == "Países")
            {
                palavraSecreta = categoria.paises[IndicePalavraSorteada()];
            }
            else if (categoria.nome == "Bandas")
            {
                palavraSecreta = categoria.bandas[IndicePalavraSorteada()];
            }
            else if (categoria.nome == "Games")
            {
                palavraSecreta = categoria.games[IndicePalavraSorteada()];
            }
        }

        public void VerificarChute(string chute)
        {
            bool letraFoiEncontrada = false;

            if (chute.Length > 1)
            {
                if (chute == palavraSecreta)
                {
                    palavraFoiEncontrada = true;
                }

                if (palavraFoiEncontrada == false)
                    qtdErros++;
            }

            else
            {
                for (int contador = 0; contador < palavraSecreta.Length; contador++)
                {
                    char letraAtual = palavraSecreta[contador];

                    if (chute[0] == letraAtual)
                    {
                        letrasEncontradas[contador] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                {
                    qtdErros++;
                }

                letrasChutadas[tentativa] = chute[0];
                tentativa++;
            }
        }

        public bool JogadorAcertou()
        {
            string palavra = String.Join("", letrasEncontradas);

            if ((palavra == palavraSecreta) || (palavraFoiEncontrada == true))
                return true;
            return false;
        }

        public bool JogadorPerdeu()
        {
            if (qtdErros > qtdTotalErros)
                return true;
            return false;
        }

        public bool LetraRepetida(string chute)
        {
            if (chute.Length == 1)
            {
                for (int i = 0; i < letrasChutadas.Length; i++)
                {
                    if (chute[0] == letrasChutadas[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
