using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tamagotchi
    {
        public Mascote mascote;
        public int fome { get; set; } = 5;
        public int descanso { get; set; } = 5;
        public int humor { get; set; } = 5;

        public void BrincarMascote()
        {
            if (humor <= 10)
            {
                humor++;
                fome--;
                descanso--;
                Console.WriteLine("Mascote brincou com você!");
            }
            else
            {
                Console.WriteLine("Seu mascote não quer mais brincar!");
            }
        }

        public void AlimentarMascote()
        {
            if (fome <= 10)
            {
                fome++;
                descanso--;
                Console.WriteLine("Mascote alimentado!");
            }
            else
            {
                Console.WriteLine("Seu mascote está satisfeito!");
            }
        }

        public void DescansarMascote()
        {
            if (descanso <= 10)
            {
                descanso+= 2;
                fome--;
                humor--;
                Console.WriteLine("Mascote está descansando!");
            }
            else
            {
                Console.WriteLine("Seu mascote está descansado!");
            }
        }

        
    }
    

}
