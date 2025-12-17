using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizexamen
{
    class Matriz
    {
    
        const int MAXF = 50;
        const int MAXC = 50;

        private int[,] x;

        private int f, c;

   

        public Matriz()
        {

            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;

        }



        public void CargarRandom(int nf, int nc, int a, int b)

        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;


            for (f1 = 1; f1 <= f; f1++)

            {
                for (c1 = 1; c1 <= c; c1++)

                {
                    x[f1, c1] = r.Next(a, b + 1);

                }

            }

        }


        public string Descargar()

        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)

            {
                for (c1 = 1; c1 <= c; c1++)

                {
                    s = s + x[f1, c1] + "\x9";


                }
                s = s + "\xd" + "\xa";

            }

            return s;

        }




        //examen
        public int Determinante3x3()
        {
            int det;

            det =
                x[1, 1] * x[2, 2] * x[3, 3] +
                x[1, 2] * x[2, 3] * x[3, 1] +
                x[1, 3] * x[2, 1] * x[3, 2]
              -
                x[1, 3] * x[2, 2] * x[3, 1] -
                x[1, 2] * x[2, 1] * x[3, 3] -
                x[1, 1] * x[2, 3] * x[3, 2];

            return det;
        }



    }
}
