namespace JogoDaForca.ConsoleApp
{
    internal class Forca
    {
        public void Desenhar(Jogo jogo)
        {
            if (jogo.qtdErros == 0)
                DesenhoInicial();
            else if (jogo.qtdErros == 1)
                DesenhoCabeca();
            else if (jogo.qtdErros == 2)
                DesenhoCorpo();
            else if (jogo.qtdErros == 3)
                DesenhoBraco1();
            else if (jogo.qtdErros == 4)
                DesenhoBraco2();
            else if (jogo.qtdErros == 5)
                DesenhoPerna1();
            else
                DesenhoEnforcamento();
        }

        public void DesenhoInicial()
        {
            Console.WriteLine(@"___________        ");
            Console.WriteLine(@"|/        |        ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                 ");
            Console.WriteLine(@"|                 ");
            Console.WriteLine(@"|                 ");
            Console.WriteLine(@"|                 ");
            Console.WriteLine(@"|____              ");
        }

        public void DesenhoCabeca()
        {
            Console.WriteLine(@"___________        ");
            Console.WriteLine(@"|/        |        ");
            Console.WriteLine(@"|        (_)       ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|____              ");
        }

        public void DesenhoCorpo()
        {
            Console.WriteLine(@"___________       ");
            Console.WriteLine(@"|/        |       ");
            Console.WriteLine(@"|        (_)      ");
            Console.WriteLine(@"|         |       ");
            Console.WriteLine(@"|         |       ");
            Console.WriteLine(@"|         |       ");
            Console.WriteLine(@"|                 ");
            Console.WriteLine(@"|                 ");
            Console.WriteLine(@"|____             ");
        }

        public void DesenhoBraco1()
        {
            Console.WriteLine(@"___________        ");
            Console.WriteLine(@"|/        |        ");
            Console.WriteLine(@"|        (_)       ");
            Console.WriteLine(@"|         |        ");
            Console.WriteLine(@"|         |\       ");
            Console.WriteLine(@"|         | \      ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|____              ");
        }

        public void DesenhoBraco2()
        {
            Console.WriteLine(@"___________        ");
            Console.WriteLine(@"|/        |        ");
            Console.WriteLine(@"|        (_)       ");
            Console.WriteLine(@"|         |        ");
            Console.WriteLine(@"|        /|\       ");
            Console.WriteLine(@"|       / | \      ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|                  ");
            Console.WriteLine(@"|____              ");
        }

        public void DesenhoPerna1()
        {
            Console.WriteLine(@"___________        ");
            Console.WriteLine(@"|/        |        ");
            Console.WriteLine(@"|        (_)       ");
            Console.WriteLine(@"|         |        ");
            Console.WriteLine(@"|        /|\       ");
            Console.WriteLine(@"|       / | \      ");
            Console.WriteLine(@"|        /         ");
            Console.WriteLine(@"|       /          ");
            Console.WriteLine(@"|____              ");
        }

        public void DesenhoEnforcamento()
        {
            Console.Clear();
            Console.WriteLine(@"___________        ");
            Console.WriteLine(@"|/        |        ");
            Console.WriteLine(@"|        (_)       ");
            Console.WriteLine(@"|         |        ");
            Console.WriteLine(@"|        /|\       ");
            Console.WriteLine(@"|       / | \      ");
            Console.WriteLine(@"|        / \       ");
            Console.WriteLine(@"|       /   \      ");
            Console.WriteLine(@"|____              ");
        }
    }
}
