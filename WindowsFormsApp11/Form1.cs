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
        private int x, y;
        public Form1()
        {
            InitializeComponent();
            
            
 
            
        }

        private void addition_Click(object sender, EventArgs e)
        {
            

        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.ColumnCount;
            int y = dataGridView1.RowCount - 1;

            int[,] matrix1 = new int[x, y];
            int[,] matrix2 = new int[x, y];
            int[,] matrix3 = new int[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    matrix1[i, j] = int.Parse (dataGridView2[i, j].Value.ToString());

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    matrix2[i, j] = int.Parse(dataGridView3[i, j].Value.ToString());

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    dataGridView1[i, j].Value = Sub(matrix1[i, j], matrix2[i, j]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            InitDataGrid(dataGridView2, x, y);
            InitDataGrid(dataGridView3, x, y);
            InitDataGrid(dataGridView1, x, y);

            

            /*matrix1[x, y] =int.Parse(dataGridView2[x, y].Value.ToString());
            matrix2[x, y] =int.Parse(dataGridView2[x, y].Value.ToString());
            matrix3[x, y] =int.Parse(dataGridView2[x, y].Value.ToString());*/

            
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
                    data.Width = data.Columns[1].Width * data.ColumnCount;
                    data.Height = data.Rows[1].Height * data.RowCount;
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int Sub(int a, int b)
        {
            int c = a - b;
            return c;

        }

        private void Sub2(DataGridView data, int n, int m, int[,] a)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(data[i, j].Value);
        }
    }
}
