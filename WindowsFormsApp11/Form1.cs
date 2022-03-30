using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[,] matrix = new int [4, 4];
            matrix[0, 0] =int.Parse(dataGridView1[0,0].Value.ToString());
            InitDataGrid(dataGridView2, 4, 4);
        }

        private void addition_Click(object sender, EventArgs e)
        {


        }

        private void subtraction_Click(object sender, EventArgs e)
        {

        }

        private void InitDataGrid(DataGridView data, int x, int y)
        {
            data.RowHeadersVisible = false ;
            data.ColumnHeadersVisible = false ;
            data.RowCount = x;
            data.ColumnCount = y;
            for (int i = 0; i < x; i++)
            {
                for ( int j = 0; j < y; j++)
                {
                    data.Columns[j].Width = 50;

                }
            }
            

            
        }


    }
}
