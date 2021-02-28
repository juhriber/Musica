using System;

namespace Musica
{
    class Program
    {
        //Faça um programa que exiba uma letra de música a sua escolha. Utilize cores em destaque no título e nos refrões.
        static void Main(string[] args)
        {
            //<---Inicio(Titulo & Cantor)--->//
            Console.Write("Titulo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("A Vida é um Rio");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Cantor: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Raffa Torres");
            Console.ResetColor();
            Console.WriteLine();
            //<---Fim(Titulo & Cantor)--->//

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A vida é um rio");
            Console.WriteLine("Estamos no mesmo barco");
            Console.WriteLine("Remaremos juntos");
            Console.WriteLine("Para onde vai esse rio");
            Console.WriteLine("Ainda não sabemos");
            Console.WriteLine("Mas, remaremos juntos");

            Console.WriteLine("Ainda temos estrelas para alcançar");
            Console.WriteLine("Sonhos para sonhar");
            Console.WriteLine("Flores para regar");
            Console.WriteLine("Mas, precisamos fazer isso juntos");
            Console.WriteLine("E vamos fazer isso juntos");

            //<---Inicio(Refrão 1)--->//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Não seremos os mesmos jamais");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Se a gente falar menos e agir mais");

            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Não seremos os mesmos jamais");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Se a gente falar menos e agir mais");
            Console.ResetColor();
            //<---Fim(Refrão 1)--->//

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A vida é um rio");
            Console.WriteLine("Estamos no mesmo barco");
            Console.WriteLine("Remaremos juntos");
            Console.WriteLine("Para onde vai esse rio");
            Console.WriteLine("Ainda não sabemos");
            Console.WriteLine("Mas, remaremos juntos");

            Console.WriteLine("Ainda temos estrelas para alcançar");
            Console.WriteLine("Sonhos para sonhar");
            Console.WriteLine("Flores para regar");
            Console.WriteLine("Mas, precisamos fazer isso juntos");
            Console.WriteLine("E vamos fazer isso juntos");
            Console.ResetColor();

            //<---Inicio(Refão 2)--->//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Não seremos os mesmos jamais");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Se a gente falar menos e agir mais");

            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Não seremos os mesmos jamais");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Se a gente falar menos e agir mais");
            Console.ResetColor();
            //<---Fim(Refrão 2)--->//

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("E se a correnteza");
            Console.WriteLine("Mudar nosso caminho");
            Console.WriteLine("É só olhar pro céu");
            Console.WriteLine("Não estamos sozinhos não");

            Console.WriteLine("E se a correnteza");
            Console.WriteLine("Mudar nosso caminho");
            Console.WriteLine("É só olhar pro céu");
            Console.WriteLine("Não estamos sozinhos não");
            
            //<---Inicio(Refrão 3)--->//
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Não seremos os mesmos jamais");
            Console.WriteLine("Se a gente falar menos e agir mais");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Não seremos os mesmos (Jamais)");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Se a gente falar menos e agir mais");
            Console.WriteLine("Se a gente falar menos");
            Console.WriteLine("Se a gente falar menos e agir mais");
            Console.WriteLine("Oh, oh, oh, oh, oh");
            Console.WriteLine("Oh, oh, oh, oh");
            Console.WriteLine("Não seremos os mesmos jamais");
            Console.WriteLine("Se a gente falar menos e agir mais");
            Console.ResetColor();
            Console.WriteLine();
            //<---Fim(Refrão 3)--->//
        }
    }
}