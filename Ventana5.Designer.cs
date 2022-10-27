
namespace Styper_v2
{
    partial class Ventana5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana5));
            this.button4 = new System.Windows.Forms.Button();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CarritoPlayer = new System.Windows.Forms.PictureBox();
            this.CarritoIA = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Moverplayer = new System.Windows.Forms.Timer(this.components);
            this.MoverIA = new System.Windows.Forms.Timer(this.components);
            this.lblVel_player = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoIA)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1220, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.BackColor = System.Drawing.Color.Transparent;
            this.lblpalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpalabra.ForeColor = System.Drawing.Color.White;
            this.lblpalabra.Location = new System.Drawing.Point(616, 380);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(66, 24);
            this.lblpalabra.TabIndex = 13;
            this.lblpalabra.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1198, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Meta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(610, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Palabra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(548, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Termina la carrera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(886, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CarritoPlayer
            // 
            this.CarritoPlayer.BackColor = System.Drawing.Color.Transparent;
            this.CarritoPlayer.Location = new System.Drawing.Point(12, 530);
            this.CarritoPlayer.Name = "CarritoPlayer";
            this.CarritoPlayer.Size = new System.Drawing.Size(100, 50);
            this.CarritoPlayer.TabIndex = 18;
            this.CarritoPlayer.TabStop = false;
            // 
            // CarritoIA
            // 
            this.CarritoIA.BackColor = System.Drawing.Color.Transparent;
            this.CarritoIA.Location = new System.Drawing.Point(12, 474);
            this.CarritoIA.Name = "CarritoIA";
            this.CarritoIA.Size = new System.Drawing.Size(100, 50);
            this.CarritoIA.TabIndex = 19;
            this.CarritoIA.TabStop = false;
            this.CarritoIA.Click += new System.EventHandler(this.CarritoIA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(564, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // Moverplayer
            // 
            this.Moverplayer.Enabled = true;
            this.Moverplayer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoverIA
            // 
            this.MoverIA.Enabled = true;
            this.MoverIA.Tick += new System.EventHandler(this.MoverIA_Tick);
            // 
            // lblVel_player
            // 
            this.lblVel_player.AutoSize = true;
            this.lblVel_player.BackColor = System.Drawing.Color.Transparent;
            this.lblVel_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVel_player.ForeColor = System.Drawing.Color.White;
            this.lblVel_player.Location = new System.Drawing.Point(12, 12);
            this.lblVel_player.Name = "lblVel_player";
            this.lblVel_player.Size = new System.Drawing.Size(99, 31);
            this.lblVel_player.TabIndex = 12;
            this.lblVel_player.Text = "Styper";
            // 
            // Ventana5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CarritoIA);
            this.Controls.Add(this.CarritoPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.lblVel_player);
            this.Controls.Add(this.button4);
            this.Name = "Ventana5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventana5_FormClosing);
            this.Load += new System.EventHandler(this.Ventana5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CarritoPlayer;
        private System.Windows.Forms.PictureBox CarritoIA;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Timer Moverplayer;
        public System.Windows.Forms.Timer MoverIA;
        private System.Windows.Forms.Label lblVel_player;
    }
}