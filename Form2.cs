using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor_Valutar
{
    public partial class Form2 : Form
    {
        public double cursEur;
        public double cursUsd;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cursEur = Convert.ToDouble(textBox1.Text);
            cursUsd = Convert.ToDouble(textBox2.Text);
            
            Form1 frm = new Form1(cursEur,cursUsd);

            this.Hide();
            frm.ShowDialog();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
