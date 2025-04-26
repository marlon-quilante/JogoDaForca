namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Jogo jogo = new Jogo();
                Forca forca = new Forca();
                Categoria categoria = new Categoria();

                ApresentarCabecalhoInicial();
                MenuCategorias();
                EscolherCategoria(categoria);

                jogo.SortearPalavra(categoria);
                jogo.letrasChutadas = new char[500];
                jogo.letrasEncontradas = new char[jogo.palavraSecreta.Length];

                while (true)
                {
                    ApresentarCabecalhoInicial();
                    ApresentarCabecalhoJogo(jogo, categoria);
                    forca.Desenhar(jogo);
                    string chute = Chute(jogo);
                    jogo.VerificarChute(chute);
                    if (jogo.JogadorAcertou())
                    {
                        ApresentarMensagemVitoria(jogo);
                        break;
                    }
                    else if (jogo.JogadorPerdeu())
                    {
                        Console.Clear();
                        forca.Desenhar(jogo);
                        ApresentarMensagemDerrota(jogo);
                        break;
                    }
                }

                if (JogarNovamente())
                    continue;
                else
                    break;
            }

        }

        static void ApresentarCabecalhoInicial()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("----------------------------");
        }

        static void MenuCategorias()
        {
            Console.WriteLine("Escolha uma categoria...\n");
            Console.WriteLine("1- Frutas");
            Console.WriteLine("2- Animais");
            Console.WriteLine("3- Países");
            Console.WriteLine("4- Bandas");
            Console.WriteLine("5- Games\n");
        }

        static void EscolherCategoria(Categoria categoria)
        {
            string opcaoCategoria = Console.ReadLine();

            while (categoria.nome == "")
            {
                if (opcaoCategoria == "1")
                    categoria.nome = "Frutas";
                else if (opcaoCategoria == "2")
                    categoria.nome = "Animais";
                else if (opcaoCategoria == "3")
                    categoria.nome = "Países";
                else if (opcaoCategoria == "4")
                    categoria.nome = "Bandas";
                else if (opcaoCategoria == "5")
                    categoria.nome = "Games";
                else
                {
                    Console.WriteLine("Opção inválida! Pressione ENTER e tente novamente...");
                    Console.ReadLine();
                    continue;
                }
            }
        }

        static void ApresentarCabecalhoJogo(Jogo jogo, Categoria categoria)
        {
            char[] letrasEncontradas = new char[jogo.palavraSecreta.Length];

            Console.WriteLine($"Categoria: {categoria.nome}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Erros: " + jogo.qtdErros);
            Console.WriteLine("----------------------------");
            Console.Write("Letras chutadas: ");

            for (int i = 0; i < jogo.letrasChutadas[i]; i++)
            {
                if (jogo.letrasChutadas[i] != '\0')
                {
                    char letra = jogo.letrasChutadas[i];
                    Console.Write(letra + " ");
                }
            }

            for (int i = 0; i < jogo.palavraSecreta.Length; i++)
            {
                if (jogo.letrasEncontradas[i] != '\0')
                {
                    letrasEncontradas[i] = jogo.letrasEncontradas[i];
                }
                else
                {
                    letrasEncontradas[i] = '_';
                }
            }

            string palavra = String.Join(" ", letrasEncontradas);

            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Palavra secreta: " + palavra);
            Console.WriteLine("----------------------------");
        }

        static string Chute(Jogo jogo)
        {
            Console.Write("\nDigite uma letra ou palavra: ");
            string chute = Console.ReadLine();

            while (jogo.LetraRepetida(chute))
            {
                Console.Write("\nVocê já chutou essa! Digite outra letra: ");
                chute = Console.ReadLine();
            }
            return chute;
        }

        static void ApresentarMensagemVitoria(Jogo jogo)
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Você acertou a palavra secreta '{jogo.palavraSecreta}'");
            Console.WriteLine("----------------------------");
        }

        static void ApresentarMensagemDerrota(Jogo jogo)
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Você perdeu! A palavra era: " + jogo.palavraSecreta);
            Console.WriteLine("----------------------------");
        }

        static bool JogarNovamente()
        {
            Console.WriteLine("1- Jogar novamente");
            Console.WriteLine("2- Sair\n");

            string opcaoEscolhida = Console.ReadLine();

            if (opcaoEscolhida == "1")
                return true;
            else
                return false;
        }
    }
}