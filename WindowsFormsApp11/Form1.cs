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

            //int[,] matrix = new int[x, y];
            //matrix[x, y] = int.Parse(dataGridView2[x, y].Value.ToString());
            //MessageBox.Show(dataGridView1.Rows[1].Cells[0].Value.ToString());
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 8;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                    dataGridView1.Rows[i].Cells[j].Value = i + j;
            }
            



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
