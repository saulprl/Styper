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
    public partial class VentanaRetos : Form
    {
        private XmlDocument playerInfo = new XmlDocument();
        private string playerName = "";

        int[] wordsChallenge = { 25, 50, 100, 150, 200, 300, 400, 500 };
        int[] gamesChallenge = { 5, 10, 20, 30, 40, 50, 75, 100, 200 };

        public VentanaRetos(string playerName)
        {
            InitializeComponent();

            label2.Text = "Escribir un total de 50 palabras correctamente.";
            label3.Text = "Escribir un total de 25 palabras de 10 caracteres o más correctamente.";
            label4.Text = "Completa 5 partidas.";
            label5.Text = "Termina 5 partidas sin errores.";

            playerInfo.Load(playerName + ".xml");
            this.playerName = playerName;

            XmlNode node = playerInfo.SelectSingleNode("/Usuario/PalabrasCorrectas");
            foreach (int interval in wordsChallenge)
            {
                if (interval > Convert.ToInt32(node.InnerText))
                {
                    label2.Text = String.Format("Escribir un total de {0} palabras correctamente.", interval);
                    break;
                }

                if (Convert.ToInt32(node.InnerText) > 500)
                {
                    label2.ForeColor = Color.Green;
                }
            }

            node = playerInfo.SelectSingleNode("/Usuario/PalabrasComplejasC");
            foreach (int interval in wordsChallenge)
            {
                if (interval > Convert.ToInt32(node.InnerText))
                {
                    label3.Text = String.Format("Escribir un total de {0} palabras de 10 caracteres o más correctamente.", interval);
                    break;
                }

                if (Convert.ToInt32(node.InnerText) > 500)
                {
                    label3.ForeColor = Color.Green;
                }
            }

            node = playerInfo.SelectSingleNode("/Usuario/Partidas");
            foreach (int interval in gamesChallenge)
            {
                if (interval > Convert.ToInt32(node.InnerText))
                {
                    label4.Text = String.Format("Completa {0} partidas.", interval);
                    break;
                }

                if (Convert.ToInt32(node.InnerText) > 200)
                {
                    label4.ForeColor = Color.Green;
                }
            }

            node = playerInfo.SelectSingleNode("/Usuario/PartidasLimpias");
            foreach (int interval in gamesChallenge)
            {
                if (interval > Convert.ToInt32(node.InnerText))
                {
                    label5.Text = String.Format("Completa {0} partidas sin errores.", interval);
                    break;
                }

                if (Convert.ToInt32(node.InnerText) > 200)
                {
                    label5.ForeColor = Color.Green;
                }
            }
        }

        private void VentanaRetos_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Ventana4 v4 = new Ventana4(playerName);
            this.Hide();
            v4.ShowDialog();
            this.Close();
        }
    }
}
