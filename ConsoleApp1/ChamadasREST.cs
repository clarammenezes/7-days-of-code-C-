using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public static class ChamadasREST
    {
        public static Mascote invocarChamadaGet(string URL)
        {
            var client = new RestClient(URL);
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //Mascote mascote = JsonSerializer.Deserialize<Mascote>(response.Content);
                try
                {
                    Mascote mascote = JsonConvert.DeserializeObject<Mascote>(response.Content);
                    return mascote;
                }
                catch (Exception ex) { throw ex; }
                
                
            }
            else
            {
                throw new Exception("Não funcionou");
            }
        }

    }
}
