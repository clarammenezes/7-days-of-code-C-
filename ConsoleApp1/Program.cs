using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InvocarGet();

            //var response = ChamadasREST.invocarChamadaGet("https://pokeapi.co/api/v2/type/8");

            //Console.WriteLine(response.ToString());

            //Console.ReadLine();

            MenuPrincipal principal = new MenuPrincipal();
            principal.menuPrincipal();

            //InvocarPost();

        }
    }
  
}
