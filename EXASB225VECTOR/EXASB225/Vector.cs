using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXASB225
{
    class Vector
    {

        const int MAX = 101;
        private int[] v;
        private int n;



        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }



        public void CargarRnd(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;

            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }



        public string Descargar()
        {
            string s = "";
            int i;

            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + "\x0009";
            }

            return s;
        }


        public void ImparesFrecuencia(ref Vector ve, ref Vector vf)
        {
    
            ve.n = 0;
            vf.n = 0;

       
            for (int i = 1; i <= n; i++)
            {
             
                if (v[i] % 2 != 0)
                {
              
                    if (!ve.Existe_ele(v[i]))
                    {
                        ve.insertar(v[i]);            
                        vf.insertar(frecuencia(v[i])); 
                    }
                }
            }

            
            for (int i = 1; i <= ve.n - 1; i++)
            {
                for (int j = i + 1; j <= ve.n; j++)
                {
                    if (ve.v[i] > ve.v[j])
                    {
                        ve.Inter(i, j);
                        vf.Inter(i, j);
                    }
                }
            }
        }

        public bool Existe_ele(int ele)
        {
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                    return true;
            }
            return false;
        }

        public int frecuencia(int ele)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                    c++;
            }
            return c;
        }


        public void Inter(int p1, int p2)
        {
            int aux;
            aux = v[p1];
            v[p1] = v[p2];
            v[p2] = aux;
        }

        public void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }


    }
}

