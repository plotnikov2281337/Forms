using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{

    class Controller
    {
        
        public delegate void Delegatte(int[,] matrix1, int[,] matrix2);
        public event Delegatte DelegatteEvent;
        public void Calculate(int[,] matrix1)
        {
            
            
        }

        
    }
}