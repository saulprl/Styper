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
    public partial class VentanaContrarreloj : Form
    {
        private string[] Palabrardm = { "hasta", "vaya", "insomnio", "razón", "conciencia", "confianza", "destreza", "hábitos",
                                "aviador", "averroísta", "atosigante", "absolutismo" };
        private Random rdm = new Random();

        private XmlDocument playerInfo = new XmlDocument();
        private int correct = 0;
        private int incorrect = 0;
        private int complexCorrect = 0;
        private int complexIncorrect = 0;
        private bool complex = false;

        private int timeCount = 0;
        private int wordCount = 0;
        private string playerName = "";
        string[] autos = { "carro.png", "carroverde.png", "carromorado.png" };

        private int carX = 30;

        public VentanaContrarreloj(string playerName, int difficulty)
        {
            InitializeComponent();

            this.playerName = playerName;
            SetDifficulty(difficulty);

            playerInfo.Load(playerName + ".xml");

            XmlNode node = playerInfo.SelectSingleNode("/Usuario/Carro");
            CarritoIA.Image = Image.FromFile(autos[Convert.ToInt32(node.InnerText) - 1]);
        }

        private void VentanaContrarreloj_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.textBox1;
            this.textBox1.KeyUp += textBox1_KeyUp;
            lblpalabra.Text = Palabrardm[rdm.Next(0, Palabrardm.Length)];
            CarritoIA.Image = Image.FromFile(autos[rdm.Next(0, autos.Length)]);

            wordsLbl.Text = wordCount.ToString();
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblpalabra.Text)
                {
                    correct++;
                    complexCorrect = complex ? complexCorrect + 1 : complexCorrect;
                    lblpalabra.Text = Palabrardm[rdm.Next(0, Palabrardm.Length)];
                    complex = lblpalabra.Text.Length >= 10;

                    textBox1.Text = null;
                    lblpalabra.ForeColor = Color.FromArgb(20, 20, 20);

                    wordsLbl.Text = (wordCount - correct).ToString();

                    if (correct == wordCount)
                    {
                        GameOver(true);
                    }
                }
                else
                {
                    incorrect++;
                    complexIncorrect = complex ? complexIncorrect + 1 : complexIncorrect;
                    lblpalabra.Text = Palabrardm[rdm.Next(0, Palabrardm.Length)];
                    complex = lblpalabra.Text.Length >= 10;

                    textBox1.Text = null;
                    lblpalabra.ForeColor = Color.FromArgb(250, 20, 20);
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == lblpalabra.Text)
            {
                lblpalabra.ForeColor = Color.FromArgb(20, 250, 20);
            }
        }

        private void VentanaContrarreloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            countdownTimer.Stop();
            playerTimer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            carX += 1;
            CarritoIA.Location = new Point(carX, 474);
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            timeCount--;
            countdownLbl.Text = timeCount.ToString();

            if (timeCount == 0)
            {
                GameOver(false);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDifficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 0:
                    this.timeCount = 300;
                    this.wordCount = 50;
                    break;
                case 1:
                    this.timeCount = 180;
                    this.wordCount = 75;
                    break;
                case 2:
                    this.timeCount = 160;
                    this.wordCount = 100;
                    break;
            }
        }

        private void GameOver(bool playerWon)
        {
            countdownTimer.Stop();
            playerTimer.Stop();
            SaveData(playerWon);

            if (playerWon)
            {
                MessageBox.Show(String.Format("Gana {0}.", playerName), "Partida terminada");
            } else
            {
                MessageBox.Show("Gana el tiempo.", "Partida terminada");
            }

            Ventana4 v4 = new Ventana4(playerName);
            this.Hide();
            v4.ShowDialog();
            this.Close();
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
