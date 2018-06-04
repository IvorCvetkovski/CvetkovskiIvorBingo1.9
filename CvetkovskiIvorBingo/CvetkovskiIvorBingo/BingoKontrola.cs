using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvetkovskiIvorBingo
{
    class BingoKontrola
    {
        List<Listic> ListaListica = new List<Listic>();
        
        public Listic kreirajListic(int[] brojevi)
        {
            Listic listic = new Listic(brojevi);
            ListaListica.Add(listic);
            return listic;
        }

        public string ispisiListic(Listic listic)
        {
            int[] bingo = listic.GetBrojevi();
            string ispisListica = "";
            for (int i = 0; i < 6; i++)
            {
                 ispisListica = ispisListica + Convert.ToString(bingo[i]);
            }
            ispisListica = ispisListica + "\n";

            return ispisListica;
        }

        public Listic izvlacenjeListica(Listic listic)
        {
            Random ran = new Random();
            int[] randomNum = new int[6];

            for(int i=0;i<6;i++)
            {
                randomNum[i] = ran.Next(1, 50);
            }

            Listic list = new Listic();
            list.SetDobitniListic(randomNum);
            return list;
        }

        public string ispisiSveListice()
        {
            string ispis = "";
            int[] tiket = new int[6];
            int[] dobitni = new int[6];
            
            foreach (Listic listic in ListaListica)
            {
                tiket = listic.GetBrojevi();
                dobitni = listic.GetDobitniListic();
                for (int i = 0; i < 6; i++)
                {
                    //ispis = ispis + Convert.ToString(listic.GetBrojevi()) + Convert.ToString(listic.GetDobitniListic());
                    ispis = ispis + Convert.ToString(tiket[i]);
                }
                ispis = ispis + "\n";

                for (int i = 0; i < 6; i++)
                {
                    ispis = ispis + Convert.ToString(dobitni[i]);
                }
            }
            return ispis;
        }
    }
}
