namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palavraSecreta = "UVA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    letrasEncontradas[caractere] = '_';
                }

                int quantidadeErros = 0;
                int tentativa = 0;

                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;
                bool letraRepetida = false;

                char[] letrasChutadas = new char[26];
                char chute;

                do
                {
                    Console.Clear();
                    string palavra = String.Join(" ", letrasEncontradas);

                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Erros: " + quantidadeErros);
                    Console.WriteLine("----------------------------");
                    Console.Write("Letras chutadas: ");
                    
                    for (int i = 0; i < letrasChutadas.Length; i++)
                    {
                        if (letrasChutadas[i] != '\0')
                        {
                            char letra = letrasChutadas[i];
                            Console.Write(letra + " ");
                        }
                    }

                    Console.WriteLine("\n----------------------------");
                    Console.WriteLine("Palavra secreta: " + palavra);
                    Console.WriteLine("----------------------------");

                    if (quantidadeErros == 0)
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

                    else if (quantidadeErros == 1)
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
                    else if (quantidadeErros == 2)
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
                    else if (quantidadeErros == 3)
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
                    else if (quantidadeErros == 4)
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
                    else if (quantidadeErros == 5)
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

                    letraRepetida = false;
                    Console.Write("\nDigite uma letra: ");
                    chute = Console.ReadLine()[0]; //obtém apenas um caracter do que o usuário digita

                    for (int i = 0; i < letrasChutadas.Length; i++)
                    {
                        if (chute == letrasChutadas[i])
                        {
                            letraRepetida = true;
                            break;
                        }
                    }

                    while (letraRepetida == true)
                    {
                        Console.Write("\nVocê já chutou essa! Digite outra letra: ");
                        chute = Console.ReadLine()[0];

                        for (int i = 0; i < letrasChutadas.Length; i++)
                        {
                            if (chute == letrasChutadas[i])
                            {
                                letraRepetida = true;
                                break;
                            } else
                            {
                                letraRepetida = false;
                            }
                        }
                    }

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    if (letraFoiEncontrada == false)
                    {
                        quantidadeErros++;
                    }

                    palavra = String.Join("", letrasEncontradas);

                    jogadorAcertou = palavra == palavraSecreta;
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"Você acertou a palavra secreta '{palavraSecreta}'");
                        Console.WriteLine("----------------------------");
                    }
                    else if (jogadorEnforcou)
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
                        Console.WriteLine("Que azar, tente novamente! A palavra era: " + palavraSecreta);
                        Console.WriteLine("----------------------------");
                    }

                    letrasChutadas[tentativa] = chute;
                    tentativa++;

                } while (jogadorAcertou == false && jogadorEnforcou == false);

                Console.Write("Pressione qualquer tecla para jogar novamente...");
                Console.ReadLine();
            }
        }
    }
}
