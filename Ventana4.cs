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

namespace Styper_v2
{
    public partial class Ventana4 : Form
    {
        private XmlDocument playerInfo = new XmlDocument();
        private string playerName = "";

        public Ventana4(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
            playerInfo.Load(playerName + ".xml");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaModo modo = new VentanaModo(playerName);
            this.Hide();
            modo.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventana2 v2 = new Ventana2();
            this.Hide();
            v2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaRetos vr = new VentanaRetos(playerName);
            this.Hide();
            vr.ShowDialog();
            this.Close();
        }

        private void Ventana4_Load(object sender, EventArgs e)
        {

        }

        private void scoresBtn_Click(object sender, EventArgs e)
        {
            VentanaPuntuaciones vp = new VentanaPuntuaciones(playerName);
            this.Hide();
            vp.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaConfig vr = new VentanaConfig(playerName);
            this.Hide();
            vr.ShowDialog();
            this.Close();
        }
    }
}
