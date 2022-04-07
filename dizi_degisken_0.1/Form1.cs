using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_degisken_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] diz = new int[50];
        Random rand = new Random();
        int rnd = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < diz.Length; i++)
            {
                rnd = rand.Next(0,100);
                diz[i] = rnd;
                listBox1.Items.Add(i + 1 + ")  " + diz[i]);               
            }
            button2.Visible = true;
            button3.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(diz);
            listBox1.Items.Clear();
            for (int i = 0; i < diz.Length; i++)
            {
                listBox1.Items.Add(i + 1 + ")  " + diz[i]);
            }

            button3.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Reverse(diz);
            listBox1.Items.Clear();
            for (int i = 0; i < diz.Length; i++)
            {
                listBox1.Items.Add(i + 1 + ")  " + diz[i]);
            }
            button2.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = diz.Min().ToString();
            textBox2.Text = diz.Max().ToString();
        }
    }
}
