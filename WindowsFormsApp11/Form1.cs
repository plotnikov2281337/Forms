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
            //int[,] matrix = new int [4, 4];
            //matrix[0, 0] =int.Parse(dataGridView1[0,0].Value.ToString());

        }

        private void subtraction_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            InitDataGrid(dataGridView2, x, y);
            InitDataGrid(dataGridView3, x, y);
            InitDataGrid(dataGridView1, x, y);
            
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

    }
}
