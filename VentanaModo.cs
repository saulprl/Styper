using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styper_v2
{
    public partial class VentanaModo : Form
    {
        private string playerName = "";

        public VentanaModo(string playerName)
        {
            InitializeComponent();

            this.playerName = playerName;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Ventana4 v4 = new Ventana4(playerName);
            this.Hide();
            v4.ShowDialog();
            this.Close();
        }

        private void raceBtn_Click(object sender, EventArgs e)
        {
            VentanaDificultad vd = new VentanaDificultad(playerName, 0);
            this.Hide();
            vd.ShowDialog();
            this.Close();
        }

        private void timeTrialBtn_Click(object sender, EventArgs e)
        {
            VentanaDificultad vd = new VentanaDificultad(playerName, 1);
            this.Hide();
            vd.ShowDialog();
            this.Close();
        }

        private void wordsRaceBtn_Click(object sender, EventArgs e)
        {
            VentanaDificultad vd = new VentanaDificultad(playerName, 2);
            this.Hide();
            vd.ShowDialog();
            this.Close();
        }
    }
}
