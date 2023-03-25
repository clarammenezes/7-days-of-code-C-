using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Mascote
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public List<TypeDescription> types { get; set; }
        public List<AbilityDescription> abilities { get; set; }

        public override string ToString()
        {
            string tipos = "", habilidades = "";
            foreach (var tipo in types)
            {
                tipos += tipo.ToString() + "\n";
            }
            foreach (var habilidade in abilities)
            {
                habilidades += habilidade.ToString() + "\n";
            }

            return $"Nome: {name}\n" +
                   $"Altura: {height}\n" +
                   $"Peso: {weight}\n" +
                   $"Tipo(s): {tipos}\n" +
                   $"Habilidades: {habilidades}";
        }

        public Mascote() { }

    }
}
