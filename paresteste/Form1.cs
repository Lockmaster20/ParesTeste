using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paresteste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculo nro = new Calculo();

        private void Button1_Click_1(object sender, EventArgs e)
        {
            nro.recebe = textBox1.Text;
            textBox2.Text = nro.resultado;
        }
    }
}
