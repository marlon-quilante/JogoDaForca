namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palavraSecreta = "";

                int quantidadeErros = 0;
                int tentativa = 0;

                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;
                bool letraRepetida = false;

                char[] letrasChutadas = new char[26];

                string[] frutas = {
                        "ABACAXI", "ACEROLA", "AMEIXA", "BANANA", "CAJU",
                        "CARAMBOLA", "CEREJA", "COCO", "DAMASCO", "FIGO",
                        "GOIABA", "JABUTICABA", "KIWI", "LARANJA", "LIMAO",
                        "MACA", "MAMAO", "MANGA", "MARACUJA", "MELANCIA" };

                string[] animais = {
                        "ABELHA", "ARARA", "CACHORRO", "CAMELO", "CAVALO",
                        "COBRA", "ELEFANTE", "ESQUILO", "GALO", "GATO",
                        "GIRAFA", "JACARE", "LEAO", "LOBO", "MACACO",
                        "ONCA", "PATO", "PEIXE", "TIGRE", "TUCANO" };

                string[] paises = {
                        "ALEMANHA", "NIGERIA", "AUSTRALIA", "BRASIL", "CANADA",
                        "CHILE", "CHINA", "COLOMBIA", "EGITO", "ESPANHA",
                        "FINLANDIA", "FRANCA", "INDIA", "ITALIA", "JAPAO",
                        "VENEZUELA", "PORTUGAL", "RUSSIA", "SUECIA", "URUGUAI" };

                string[] bandas =
                {
                    "ANGRA", "AVENGEDSEVENFOLD", "BLACKSABBATH", "BLINDGUARDIAN", "BONJOVI",
                    "DISTURBED", "EDSHEERAN", "ELVIS", "EVANESCENCE", "IRONMAIDEN",
                    "LINKINPARK", "LVCAS", "METALLICA", "MILEYCYRUS", "OZZY",
                    "PEARLJAM", "PINKFLOYD", "RHCP", "RUSH", "SLIPKNOT"
                };

                string[] games =
                {
                    "AMNESIA", "BIOSHOCK", "BULLY", "CALLOFDUTY", "DETROIT",
                    "FNAF", "GODOFWAR", "GTA", "LEAGUEOFLEGENDS", "LIFEISSTRANGE",
                    "MAXPAYNE", "NEEDFORSPEED", "OUTLAST", "PAPERSPLEASE", "REDDEADREDEMPTION",
                    "RESIDENTEVIL", "THELASTOFUS", "TOMBRAIDER", "UNCHARTED", "UNDERTALE"
                };

                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Escolha uma categoria...\n");
                Console.WriteLine("1- Frutas");
                Console.WriteLine("2- Animais");
                Console.WriteLine("3- Países");
                Console.WriteLine("4- Bandas");
                Console.WriteLine("5- Games\n");

                string categoria = Console.ReadLine();

                Random sorteador = new Random();
                int indicePalavraSorteada = sorteador.Next(0, 20);

                if (categoria == "1")
                {
                    palavraSecreta = frutas[indicePalavraSorteada];
                    categoria = "Frutas";
                }
                else if (categoria == "2")
                {
                    palavraSecreta = animais[indicePalavraSorteada];
                    categoria = "Animais";
                }
                else if (categoria == "3")
                {
                    palavraSecreta = paises[indicePalavraSorteada];
                    categoria = "Países";
                }
                else if (categoria == "4")
                {
                    palavraSecreta = bandas[indicePalavraSorteada];
                    categoria = "Bandas";
                }
                else if (categoria == "5")
                {
                    palavraSecreta = games[indicePalavraSorteada];
                    categoria = "Games";
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    continue;
                }

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    letrasEncontradas[caractere] = '_';
                }

                do
                {
                    Console.Clear();
                    string palavra = String.Join(" ", letrasEncontradas);
                    char chute;

                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Categoria: " + categoria);
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
                    string chutePalavra = Console.ReadLine(); //obtém apenas um caracter do que o usuário digita

                    bool palavraFoiEncontrada = false;

                    if (chutePalavra.Length > 1)
                    {
                        if (chutePalavra == palavraSecreta)
                        {
                            palavraFoiEncontrada = true;
                        }

                        if (palavraFoiEncontrada == false)
                        {
                            quantidadeErros++;
                        }
                    }
                    else
                    {
                        chute = chutePalavra[0];

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
                                }
                                else
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
                        letrasChutadas[tentativa] = chute;
                    }

                    jogadorAcertou = palavra == palavraSecreta || palavraFoiEncontrada == true;
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
                        Console.WriteLine("Você perdeu! A palavra era: " + palavraSecreta);
                        Console.WriteLine("----------------------------");
                    }

                    tentativa++;

                } while (jogadorAcertou == false && jogadorEnforcou == false);

                Console.Write("\nPressione qualquer tecla para jogar novamente...");
                Console.ReadLine();
            }
        }
    }
}
