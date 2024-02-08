using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220048
{
    internal class ProductTest
    {
        
        static void Main(string[] args)
        {
            Coc_714220048 game1 = new Coc_714220048("ClashOfClans", "Game strategi real-time", "2012");
            PUBG_714220048 game2 = new PUBG_714220048("Game battle royal", "2017");

            Console.WriteLine("Game 1 is called {0}, The genre of this game is \"{1}\" and produced in {2} ", game1.MyType, game1.MyTitle, game1.TahunCount);
            Console.WriteLine("Game 2 is called {0}, The genre of this game is \"{1}\" and produced in {2} ", game2.MyType, game2.MyTitle, game2.TahunCount);
        }
    }
}
