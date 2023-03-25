using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public class MenuPrincipal
    {

        public string usuario { get; set; }

        public string nomeMascote { get; set; }

        public List<string> mascoteAdotado = new List<string>();

        public void menuPrincipal()
        {
            Console.WriteLine(" _                                    _       _     _ \r\n| |                                  | |     | |   (_)\r\n| |_ __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ \r\n| __/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |\r\n| || (_| | | | | | | (_| | (_| | (_) | || (__| | | | |\r\n \\__\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|\r\n                           __/ |                      \r\n                          |___/    ");
            Console.WriteLine("Seja bem-vindo ao Tamagotchi\n");
            usuario = nomeUsuario();
            menuMascote();

        }

        public string nomeUsuario()
        {

            Console.WriteLine("Para começarmos, por favor insira seu nome: ");
            string user = Console.ReadLine();

            return user;
        }
        
        public void menuMascote()
        {
            Console.Clear();
            Console.WriteLine(usuario + ", o que você deseja?\n");
            Console.WriteLine("1 - ADOTAR UM MASCOTE VIRTUAL\n2 - VER SEUS MASCOTES\n3 - SAIR DO PROGRAMA");
            Console.WriteLine("ESCOLHA: ");
            string escolha = Console.ReadLine();
            Console.WriteLine(escolha);
            Console.Clear();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("ESCOLHA UM MASCOTE PARA ADOTAR\n");
                    Console.WriteLine("1 - GENGAR\n2 - CLEFAIRY\n3 - LUGIA\n4 - GIRAFARIG");
                    string numeroMascote = Console.ReadLine();
                    switch (numeroMascote)
                    {
                        case "1":
                            nomeMascote = "GENGAR";
                            break;
                        case "2":
                            nomeMascote = "CLEFAIRY";
                            break;
                        case "3":
                            nomeMascote = "LUGIA";
                            break;
                        case "4":
                            nomeMascote = "GIRAFARIG";
                            break;
                    }
                    
                    detalheMascote(nomeMascote);
                    break;
                case "2":
                    Console.WriteLine("SEUS MASCOTES SÃO: ");
                    string mascotes = "";
                    foreach (var mascote in mascoteAdotado)
                    {
                        mascotes += mascote + "\n";
                    }
                    Console.WriteLine(mascotes);
                    break;
                case "3":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Nenhuma escolha foi aceita!");
                    break;
            }

            Console.ReadLine();

        }
        public void detalheMascote(string mascote)
        {
            Console.Clear();
            Console.WriteLine("O QUE VOCÊ DESEJA SABER SOBRE O MASCOTE: " + mascote);
            Console.WriteLine("1 - SABER MAIS SOBRE O MASCOTE\n2 - ADOTAR O MASCOTE\n3 - VOLTAR");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("INFORMAÇÕES SOBRE O MASCOTE: " + mascote + "\n");
                    Console.WriteLine(ChamadasREST.invocarChamadaGet("https://pokeapi.co/api/v2/pokemon/" + mascote.ToLower()));
                    break;
                case "2":
                    Console.WriteLine("ADOTAR O MASCOTE: " + mascote);
                    Console.WriteLine("1 - SIM\n2 - NÃO");
                    string escolhaAdotar = Console.ReadLine();
                    switch (escolhaAdotar)
                    {
                        case "1":
                            mascoteAdotado.Add(mascote);
                            
                            Console.WriteLine("PARABÉNS PELA A ADOÇÃO DO SEU NOVO MASCOTE, CONFIRA O OVO CHOCANDO DO SEU MASCOTE");
                            Console.WriteLine("                                                                          \r\n                                                                          \r\n                                                                          \r\n                                ████████                                  \r\n                              ██        ██                                \r\n                            ██▒▒▒▒        ██                              \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          \r\n                        ██                ▒▒▒▒██                          \r\n                      ██▒▒      ▒▒▒▒▒▒          ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        \r\n                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        \r\n                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          \r\n                        ██▒▒▒▒            ▒▒▒▒██                          \r\n                          ██▒▒              ██                            \r\n                            ████        ████                              \r\n                                ████████                                  \r\n                                                                          \r\n                                                                          \r\n                                                                          \r\n");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("\n\n\n                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          \r\n                        ██                ▒▒▒▒██                          \r\n                      ██▒▒      ▒▒▒▒▒▒          ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        \r\n                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        \r\n                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          \r\n                        ██▒▒▒▒            ▒▒▒▒██                          \r\n                          ██▒▒              ██                            \r\n                            ████        ████                              \r\n                                ████████   ");
                            Console.WriteLine("Voltar ao menu principal?");
                            if (Console.ReadLine() == "y") menuMascote();
                            break;
                        case "2":
                            detalheMascote(nomeMascote); 
                            break;
                    }
                    break;
                case "3":
                    menuMascote();
                    break;
            }   
            

        }


    }
}
