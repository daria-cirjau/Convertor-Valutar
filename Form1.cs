using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Convertor_Valutar
{
    public partial class Form1 : Form
    {public int change = 0;
        public double cursEur;
        public double cursUsd;
        public double suma;
        

        public Form1()
        {
            InitializeComponent();

        }

        public Form1(double ce, double cu)
        {
           
            InitializeComponent();
            change = 1;
            cursEur = ce;
            cursUsd = cu;
            label1.Text = "EUR:" + ce.ToString();
            label2.Text = "USD:" + cu.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (change == 0)
            {
                try
                { 
                    StreamReader sr = new StreamReader("curs.txt");
                    cursEur = Convert.ToDouble(sr.ReadLine());
                    cursUsd = Convert.ToDouble(sr.ReadLine());
                }
                catch (System.IO.FileNotFoundException)
                { cursEur = 0; cursUsd = 0; }//exceptia - in caz de eroare, daca fisierul nu exista
                label1.Text = "Eur:" + cursEur.ToString();
                label2.Text = "Usd:" + cursUsd.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suma = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                label5.Text = "euro:" + (suma / cursEur).ToString();
                label6.Text = "dolar:" + (suma / cursUsd).ToString();
            }
            else
                if (radioButton2.Checked)
            {
                label5.Text = "ron:" + (suma / cursEur).ToString();
                label6.Text = "dolar:" + (suma * (cursEur / cursUsd)).ToString();
            }
                else
                    if (radioButton3.Checked)
                {
                    label5.Text = "ron:" + (suma  / cursUsd).ToString();
                    label6.Text = "euro:" + (suma * (cursUsd / cursEur)).ToString();
                }
        }
    }
}
