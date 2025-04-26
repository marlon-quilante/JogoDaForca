namespace JogoDaForca.ConsoleApp
{
    internal class Forca
    {
        public void Desenhar(Jogo jogo)
        {
            if (jogo.qtdErros == 0)
            {
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|                  ");
                Console.WriteLine("|                  ");
                Console.WriteLine(@"|                 ");
                Console.WriteLine(@"|                 ");
                Console.WriteLine(@"|                 ");
                Console.WriteLine(@"|                 ");
                Console.WriteLine("|____              ");
            }

            else if (jogo.qtdErros == 1)
            {
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|        (_)       ");
                Console.WriteLine("|                  ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine("|____              ");
            }
            else if (jogo.qtdErros == 2)
            {
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|        (_)       ");
                Console.WriteLine("|         |        ");
                Console.WriteLine(@"|         |       ");
                Console.WriteLine(@"|         |       ");
                Console.WriteLine(@"|                 ");
                Console.WriteLine(@"|                 ");
                Console.WriteLine("|____              ");
            }
            else if (jogo.qtdErros == 3)
            {
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|        (_)       ");
                Console.WriteLine("|         |        ");
                Console.WriteLine(@"|         |\       ");
                Console.WriteLine(@"|         | \      ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine("|____              ");
            }
            else if (jogo.qtdErros == 4)
            {
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|        (_)       ");
                Console.WriteLine("|         |        ");
                Console.WriteLine(@"|        /|\       ");
                Console.WriteLine(@"|       / | \      ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine(@"|                  ");
                Console.WriteLine("|____              ");
            }
            else if (jogo.qtdErros == 5)
            {
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|        (_)       ");
                Console.WriteLine("|         |        ");
                Console.WriteLine(@"|        /|\       ");
                Console.WriteLine(@"|       / | \      ");
                Console.WriteLine(@"|        /         ");
                Console.WriteLine(@"|       /          ");
                Console.WriteLine("|____              ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("___________        ");
                Console.WriteLine("|/        |        ");
                Console.WriteLine("|        (_)       ");
                Console.WriteLine("|         |        ");
                Console.WriteLine(@"|        /|\       ");
                Console.WriteLine(@"|       / | \      ");
                Console.WriteLine(@"|        / \       ");
                Console.WriteLine(@"|       /   \      ");
                Console.WriteLine("|____              ");
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Você perdeu! A palavra era: " + jogo.palavraSecreta);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
