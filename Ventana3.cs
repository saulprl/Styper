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
    public partial class Ventana3 : Form
    {
        int a = 1;
        string carro1 = "carro.png";
        string carro2 = "carroverde.png";
        string carro3 = "carromorado.png";
        string valorCarro = "1";
        string player;

        public Ventana3(string playerName)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("carro.png");
            player = playerName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventana2 v2 = new Ventana2();
            this.Hide();
            v2.ShowDialog();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(valorCarro);
            count++;
            valorCarro = count.ToString();

            switch(count)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(carro1);
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(carro2);
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(carro3);
                    break;
                default:
                    count = 1;
                    pictureBox1.Image = Image.FromFile(carro1);
                    valorCarro = count.ToString();
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(valorCarro);
            count--;
            valorCarro = count.ToString();

            switch (count)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(carro1);
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(carro2);
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(carro3);
                    break;
                default:
                    count = 3;
                    pictureBox1.Image = Image.FromFile(carro3);
                    valorCarro = count.ToString();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ventana2 v2 = new Ventana2();
            //string nombre = "Kevin";

            if (!File.Exists(player + ".xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("Usuario");
                xmlDoc.AppendChild(rootNode);

                XmlNode datoNode = xmlDoc.CreateElement("Nombre");
                datoNode.InnerText = player;
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("Carro");
                datoNode.InnerText = valorCarro;
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("Partidas");
                datoNode.InnerText = "0";
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("PartidasLimpias");
                datoNode.InnerText = "0";
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("PalabrasComplejasC");
                datoNode.InnerText = "0";
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("PalabrasComplejasI");
                datoNode.InnerText = "0";
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("PalabrasCorrectas");
                datoNode.InnerText = "0";
                rootNode.AppendChild(datoNode);

                datoNode = xmlDoc.CreateElement("PalabrasIncorrectas");
                datoNode.InnerText = "0";
                rootNode.AppendChild(datoNode);

                xmlDoc.Save(player + ".xml");
            }
            
            if (File.Exists(player + ".xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(player + ".xml");

                XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("/Usuario/Carro");
                node.InnerText = valorCarro;
                xmlDoc.Save(player + ".xml");
            }

            Ventana4 v4 = new Ventana4(player);
            this.Hide();
            v4.ShowDialog();
            this.Close();
        }

        private void Ventana3_Load(object sender, EventArgs e)
        {

        }
    }
}
