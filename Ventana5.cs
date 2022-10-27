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
    public partial class Ventana5 : Form
    {
        string[] Palabrardm = { "hasta", "vaya", "insomnio", "razón", "conciencia", "confianza", "destreza", "hábitos",
                                "aviador", "averroísta", "atosigante", "absolutismo" };

        private XmlDocument playerInfo = new XmlDocument();
        private int correct = 0;
        private int incorrect = 0;
        private int complexCorrect = 0;
        private int complexIncorrect = 0;
        private bool complex = false;

        private Random rdm = new Random();

        int Velocidad = 20;
        double velocidad_interna = 0.5;
        double carrito = 60;
        int vel_ia = 120;

        int difficulty = 1;
        string[] autos = { "carro.png", "carroverde.png", "carromorado.png" };
        string playerName = "";

        public Ventana5(string playerName, int difficulty)
        {
            InitializeComponent();
            lblpalabra.Text = Palabrardm[rdm.Next(0, Palabrardm.Length)];
            CarritoIA.Image = Image.FromFile(autos[rdm.Next(0, autos.Length)]);

            this.playerName = playerName;
            this.difficulty = difficulty;
            playerInfo.Load(playerName + ".xml");

            XmlNode node = playerInfo.SelectSingleNode("/Usuario/Carro");
            CarritoPlayer.Image = Image.FromFile(autos[Convert.ToInt32(node.InnerText) - 1]);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            carrito = carrito + velocidad_interna;
            CarritoPlayer.Location = new Point((int) Math.Floor(carrito), 474);
            if (carrito > 1200)
            {
                Moverplayer.Stop();
                MoverIA.Stop();
                SaveData(true);
                MessageBox.Show("Gana " + playerName + ".", "Carrera terminada");

                Ventana4 v4 = new Ventana4(playerName);
                this.Hide();
                v4.ShowDialog();
                this.Close();
            }
            //comprobar si llego a la meta
            if (vel_ia > 1200)
            {
                Moverplayer.Stop();
                MoverIA.Stop();
                SaveData(false);
                MessageBox.Show("Gana la CPU", "Carrera terminada");

                Ventana4 v4 = new Ventana4(playerName);
                this.Hide();
                v4.ShowDialog();
                this.Close();
            }
        }

        private void Ventana5_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == lblpalabra.Text)
            {
                lblpalabra.ForeColor = Color.FromArgb(20, 250, 20);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblpalabra.Text)
                {
                    correct++;
                    complexCorrect = complex ? complexCorrect + 1 : complexCorrect;
                    Velocidad = (Velocidad + 8) >= 180 ? 180 : Velocidad + 8;
                    lblpalabra.Text = Palabrardm[rdm.Next(0, Palabrardm.Length)];
                    complex = lblpalabra.Text.Length >= 10;

                    textBox1.Text = null;
                    lblpalabra.ForeColor = Color.FromArgb(20, 20, 20);
                    velocidad_interna = TranslateSpeed(Velocidad);
                }
                else
                {
                    incorrect++;
                    complexIncorrect = complex ? complexIncorrect + 1 : complexIncorrect;
                    Velocidad = (Velocidad - 6) <= 0 ? 0 : Velocidad - 6;
                    lblpalabra.Text = Palabrardm[rdm.Next(0, Palabrardm.Length)];
                    complex = lblpalabra.Text.Length >= 10;

                    textBox1.Text = null;
                    lblpalabra.ForeColor = Color.FromArgb(250, 20, 20);
                    velocidad_interna = TranslateSpeed(Velocidad);
                }
                lblVel_player.Text = "Velocidad: " + Velocidad + "km/h";

            }
        }

        private void Ventana5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Moverplayer.Stop();
            MoverIA.Stop();
        }

        private void CarroIA(object sender, EventArgs e)
        {
            {
                vel_ia += 2;
                CarritoIA.Location = new Point(vel_ia, 215);
                //comprobar si llego a la meta

            }

        }
        private void CarritoIA_Click(object sender, EventArgs e)
        {

        }

        private void MoverIA_Tick(object sender, EventArgs e)
        {
            switch (difficulty)
            {
                case 0:
                    vel_ia += 1;
                    break;
                case 1:
                    vel_ia += 2;
                    break;
                case 2:
                    vel_ia += 3;
                    break;
            }

            CarritoIA.Location = new Point(vel_ia, 530);
            //comprobar si llego a la meta
        }

        private double TranslateSpeed(double speed)
        {
            return speed / 30;
        }

        private void SaveData(bool playerWon)
        {
            XmlNode node = playerInfo.SelectSingleNode("/Usuario/Partidas");
            node.InnerText = Convert.ToString(Convert.ToInt32(node.InnerText) + 1);

            if (incorrect == 0 && playerWon)
            {
                node = playerInfo.SelectSingleNode("/Usuario/PartidasLimpias");
                node.InnerText = Convert.ToString(Convert.ToInt32(node.InnerText) + 1);
            }

            node = playerInfo.SelectSingleNode("/Usuario/PalabrasComplejasC");
            node.InnerText = Convert.ToString(Convert.ToInt32(node.InnerText) + complexCorrect);

            node = playerInfo.SelectSingleNode("/Usuario/PalabrasComplejasI");
            node.InnerText = Convert.ToString(Convert.ToInt32(node.InnerText) + complexIncorrect);

            node = playerInfo.SelectSingleNode("/Usuario/PalabrasCorrectas");
            node.InnerText = Convert.ToString(Convert.ToInt32(node.InnerText) + correct);

            node = playerInfo.SelectSingleNode("/Usuario/PalabrasIncorrectas");
            node.InnerText = Convert.ToString(Convert.ToInt32(node.InnerText) + incorrect);

            playerInfo.Save(playerName + ".xml");
        }
    }
}
