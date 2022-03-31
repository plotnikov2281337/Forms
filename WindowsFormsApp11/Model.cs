using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    internal class Model
    {
        public delegate void Message(int [,] result);
        public event Message MessageEvent;
        public event Message MessageEvent2;

        public void Add2(int[,] a, int[,] b)
        {   
            int x = a.Length;
            int y = b.Length;
            int[,] result = new int[x,y];
            
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    result[i, j] = Add(a[i, j], b[i, j]);

           MessageEvent.Invoke(result);

        }

        public void Sub2(int[,] a, int[,] b)
        {
            int x = a.Length;
            int y = b.Length;
            int[,] result = new int[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    result[i, j] = Sub(a[i, j], b[i, j]);

            MessageEvent2.Invoke(result);

        }

        private int Sub(int a, int b)
        {
            int c = a - b;
            return c;

        }

        private int Add(int a, int b)
        {
            int c = a + b;
            return c;

        }
    }
}
