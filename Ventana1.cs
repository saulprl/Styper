using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Styper_v2
{
    public partial class Ventana1 : Form
    {
        public static WindowsMediaPlayer wp = new WindowsMediaPlayer();
        
        public Ventana1()
        {
            InitializeComponent();
            wp.URL = "Music.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //wp.controls.play();
            wp.settings.volume = 5;
            wp.settings.autoStart = true;
            wp.settings.setMode("loop", true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana2 v2 = new Ventana2();
            this.Hide();
            v2.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
