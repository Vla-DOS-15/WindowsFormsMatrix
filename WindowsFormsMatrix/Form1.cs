using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 6;
            dataGridView2.RowCount = 6;
            dataGridView2.ColumnCount = 5;
            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    var n = random.Next(-99, 99);
                    dataGridView1.Rows[i].Cells[j].Value = n;
                    dataGridView2.Rows[j].Cells[i].Value = n;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = 0;
            dataGridView2.ColumnCount = 0;
            int n, m;
            int.TryParse(textBox3.Text, out n);
            int.TryParse(textBox4.Text, out m);
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    dataGridView2.Columns[j].Width = 60;
                }
            }
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int n = dataGridView1.RowCount;
        //        int m = dataGridView1.ColumnCount;
        //        dataGridView3.RowCount = n;
        //        dataGridView3.ColumnCount = m;
        //        int[,] a = new int[n, m];
        //        int[,] c = new int[n, m];
        //        for(int i = 0; i < n; i++)
        //            for(int j = 0; j < m; j++)
        //                a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
        //        for(int i = 0; i < n; i++)
        //            for(int j = 0; j < m; j++)
        //            {
        //                c[i, j] = a[j, i];
        //                dataGridView3[j, i].Value = c[i, j];
        //            }
        //    }
        //    catch(Exception)
        //    {
        //        MessageBox.Show("Введите матрицу");
        //    }
        //}


        private void button1_Click_1(object sender, EventArgs e)
        {
            int n, m;
            int.TryParse(textBox1.Text, out n);
            int.TryParse(textBox2.Text, out m);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            Random rnd = new Random();

            int elem = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    dataGridView1.Columns[j].Width = 60;
                    elem = rnd.Next(-99, 99);
                    dataGridView1.Rows[i].Cells[j].Value = elem;
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int n, m;
            int.TryParse(textBox3.Text, out n);
            int.TryParse(textBox4.Text, out m);
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;
            Random rnd = new Random();

            int elem = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    dataGridView2.Columns[j].Width = 60;
                    elem = rnd.Next(-99, 99);
                    dataGridView2.Rows[i].Cells[j].Value = elem;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(((Convert.ToInt16(textBox1.Text)) == (Convert.ToInt16(textBox3.Text))) &
                    ((Convert.ToInt16(textBox2.Text)) == (Convert.ToInt16(textBox4.Text))))
                {
                    int n = dataGridView1.RowCount;
                    int m = dataGridView1.ColumnCount;
                    dataGridView3.RowCount = n;
                    dataGridView3.ColumnCount = m;
                    int[,] a = new int[n, m];
                    int[,] b = new int[n, m];
                    int[,] c = new int[n, m];
                    for(int i = 0; i < n; i++)
                        for(int j = 0; j < m; j++)
                            a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    for(int i = 0; i < n; i++)
                        for(int j = 0; j < m; j++)
                            b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    for(int i = 0; i < n; i++)
                        for(int j = 0; j < m; j++)
                        {
                            c[i, j] = a[i, j] + b[i, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                }
                else
                {
                    MessageBox.Show("Складывать можно только матрицы одинакового размера");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(((Convert.ToInt16(textBox1.Text)) == (Convert.ToInt16(textBox3.Text))) &
                    ((Convert.ToInt16(textBox2.Text)) == (Convert.ToInt16(textBox4.Text))))
                {
                    int n = dataGridView1.RowCount;
                    int m = dataGridView1.ColumnCount;
                    dataGridView3.RowCount = n;
                    dataGridView3.ColumnCount = m;
                    int[,] a = new int[n, m];
                    int[,] b = new int[n, m];
                    int[,] c = new int[n, m];
                    for(int i = 0; i < n; i++)
                        for(int j = 0; j < m; j++)
                            a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    for(int i = 0; i < n; i++)
                        for(int j = 0; j < m; j++)
                            b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    for(int i = 0; i < n; i++)
                        for(int j = 0; j < m; j++)
                        {
                            c[i, j] = a[i, j] - b[i, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                }
                else
                {
                    MessageBox.Show("Вычитать можно только матрицы одинакового размера");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if((Convert.ToInt16(textBox2.Text)) == (Convert.ToInt16(textBox3.Text)))
            {
                int n = dataGridView1.RowCount;
                int m = dataGridView1.ColumnCount;
                int k = dataGridView2.ColumnCount;
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = k;
                int[,] a = new int[n, m];
                int[,] b = new int[m, k];
                int[,] c = new int[n, k];
                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                        a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                for(int i = 0; i < m; i++)
                    for(int j = 0; j < k; j++)
                        b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);

                for(int i = 0; i < n; i++)
                    for(int j = 0; j < k; j++)
                    {
                        c[i, j] = 0;
                        for(int r = 0; r < m; r++)
                        {
                            c[i, j] += a[i, r] * b[r, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                    }
            }
            else
            {
                MessageBox.Show("Умножать матрицы можно только когда количество столбцов первой матрицы равно количеству строк второй матрицы");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridView1.RowCount;
                int m = dataGridView1.ColumnCount;
                int x = int.Parse(textBox5.Text);
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = m;
                int[,] a = new int[n, m];
                int[,] c = new int[n, m];
                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                        a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                    {
                        c[i, j] = a[i, j] * x;
                        dataGridView3[i, j].Value = c[i, j];
                    }
            }
            catch(Exception)
            {
                MessageBox.Show("Введите число");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridView1.RowCount;
                int m = dataGridView1.ColumnCount;
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = m;
                int[,] a = new int[n, m];
                int[,] c = new int[n, m];
                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                        a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                    {
                        c[i, j] = a[j, i];
                        dataGridView3[j, i].Value = c[i, j];
                    }
            }
            catch(Exception)
            {
                MessageBox.Show("Введите матрицу");
            }
        }
    }
}