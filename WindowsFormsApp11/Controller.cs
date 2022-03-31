using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{    
     
    class Controller
    {
        private Model model;
        public delegate void Delegatte(int[,] matrix1, int[,] matrix2);
        public event Delegatte DelegatteEvent;
        public void CalculateAdd(int[,] matrix1, int[,] matrix2)
        {
            model(matrix1, matrix2);
        }

        public void CalculateSub(int[,] matrix1, int[,] matrix2)
        {
            model(matrix1, matrix2);
        }
    }
}
