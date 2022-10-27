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
    public partial class VentanaDificultad : Form
    {
        private string playerName = "";
        private int mode = 0;

        public VentanaDificultad(string playerName, int mode)
        {
            InitializeComponent();

            this.playerName = playerName;
            this.mode = mode;
        }

        private void VentanaDificultad_Load(object sender, EventArgs e)
        {
            if (mode == 2)
            {
                this.easyBtn.Text = "Express";
                this.mediumBtn.Text = "Sencillo";
                this.hardBtn.Text = "Styper";
            }
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

        private void easyBtn_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    Ventana5 v5 = new Ventana5(playerName, 0);
                    this.Hide();
                    v5.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    VentanaContrarreloj vc = new VentanaContrarreloj(playerName, 0);
                    this.Hide();
                    vc.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    VentanaCarrera vr = new VentanaCarrera(playerName, 0);
                    this.Hide();
                    vr.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    Ventana5 v5 = new Ventana5(playerName, 1);
                    this.Hide();
                    v5.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    VentanaContrarreloj vc = new VentanaContrarreloj(playerName, 1);
                    this.Hide();
                    vc.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    VentanaCarrera vr = new VentanaCarrera(playerName, 1);
                    this.Hide();
                    vr.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    Ventana5 v5 = new Ventana5(playerName, 2);
                    this.Hide();
                    v5.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    VentanaContrarreloj vc = new VentanaContrarreloj(playerName, 2);
                    this.Hide();
                    vc.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    VentanaCarrera vr = new VentanaCarrera(playerName, 2);
                    this.Hide();
                    vr.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            VentanaModo vm = new VentanaModo(playerName);
            this.Hide();
            vm.ShowDialog();
            this.Close();
        }
    }
}
