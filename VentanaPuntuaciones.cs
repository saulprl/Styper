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
    public partial class VentanaPuntuaciones : Form
    {
        private XmlDocument playerInfo = new XmlDocument();

        private string playerName = "";
        private string path = AppContext.BaseDirectory;

        public VentanaPuntuaciones(string playerName)
        {
            InitializeComponent();

            this.playerName = playerName;
            playerInfo.Load(playerName + ".xml");
        }

        private void VentanaPuntuaciones_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("Puntuaciones");
            DataColumn column;
            DataRow row;
            DataSet dataSet;

            column = new DataColumn("Nombre");
            column.DataType = System.Type.GetType("System.String");
            column.AutoIncrement = false;
            column.Caption = "Nombre";
            column.ReadOnly = true;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn("Partidas");
            column.DataType = System.Type.GetType("System.String");
            column.AutoIncrement = false;
            column.Caption = "Partidas";
            column.ReadOnly = true;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn("Palabras correctas");
            column.DataType = System.Type.GetType("System.String");
            column.AutoIncrement = false;
            column.Caption = "Palabras correctas";
            column.ReadOnly = true;
            column.Unique = false;

            table.Columns.Add(column);

            DataColumn scoreColumn = new DataColumn("Puntuación");
            scoreColumn.DataType = System.Type.GetType("System.String");
            scoreColumn.AutoIncrement = false;
            scoreColumn.Caption = "Puntuación";
            scoreColumn.ReadOnly = true;
            scoreColumn.Unique = false;

            table.Columns.Add(scoreColumn);

            dataSet = new DataSet();
            dataSet.Tables.Add(table);

            foreach (string file in Directory.GetFiles(path, "*.xml"))
            {
                playerInfo.Load(file);
                row = table.NewRow();

                XmlNode node = playerInfo.SelectSingleNode("/Usuario/Nombre");
                row["Nombre"] = node.InnerText;

                node = playerInfo.SelectSingleNode("/Usuario/Partidas");
                row["Partidas"] = node.InnerText;
                int games = Convert.ToInt32(node.InnerText);

                node = playerInfo.SelectSingleNode("/Usuario/PalabrasCorrectas");
                row["Palabras correctas"] = node.InnerText;
                int words = Convert.ToInt32(node.InnerText);

                int score = words * (11 + games);
                row["Puntuación"] = score.ToString();

                table.Rows.Add(row);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "Puntuaciones";
            dataGridView1.Sort(dataGridView1.Columns["Puntuación"], ListSortDirection.Descending);
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Ventana4 v4 = new Ventana4(playerName);
            this.Hide();
            v4.ShowDialog();
            this.Close();
        }
    }
}
