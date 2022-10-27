using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Styper_v2
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void WndProc(ref Message m) //Este método funciona para quitar la barra de título - Kevstrosky
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ingresa tu nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Ingresa tu nombre";
                textBox1.ForeColor = Color.LightSteelBlue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = textBox1.Text;

            Ventana3 v3 = new Ventana3(dato);
            this.Hide();
            v3.ShowDialog();
            this.Close();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }
    }
}
