namespace Styper_v2
{
    partial class VentanaCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCarrera));
            this.CarritoIA = new System.Windows.Forms.PictureBox();
            this.CarritoPlayer = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.lblVel_player = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.playerCountLbl = new System.Windows.Forms.Label();
            this.IACountLbl = new System.Windows.Forms.Label();
            this.IATimer = new System.Windows.Forms.Timer(this.components);
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CarritoIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // CarritoIA
            // 
            this.CarritoIA.BackColor = System.Drawing.Color.Transparent;
            this.CarritoIA.Location = new System.Drawing.Point(12, 530);
            this.CarritoIA.Name = "CarritoIA";
            this.CarritoIA.Size = new System.Drawing.Size(100, 50);
            this.CarritoIA.TabIndex = 21;
            this.CarritoIA.TabStop = false;
            // 
            // CarritoPlayer
            // 
            this.CarritoPlayer.BackColor = System.Drawing.Color.Transparent;
            this.CarritoPlayer.Location = new System.Drawing.Point(12, 474);
            this.CarritoPlayer.Name = "CarritoPlayer";
            this.CarritoPlayer.Size = new System.Drawing.Size(100, 50);
            this.CarritoPlayer.TabIndex = 20;
            this.CarritoPlayer.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(134, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Palabra";
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.BackColor = System.Drawing.Color.Transparent;
            this.lblpalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpalabra.ForeColor = System.Drawing.Color.White;
            this.lblpalabra.Location = new System.Drawing.Point(186, 276);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(66, 24);
            this.lblpalabra.TabIndex = 22;
            this.lblpalabra.Text = "label2";
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
            this.lblVel_player.TabIndex = 25;
            this.lblVel_player.Text = "Styper";
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
            this.button4.TabIndex = 26;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // playerCountLbl
            // 
            this.playerCountLbl.AutoSize = true;
            this.playerCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.playerCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCountLbl.ForeColor = System.Drawing.Color.White;
            this.playerCountLbl.Location = new System.Drawing.Point(180, 97);
            this.playerCountLbl.Name = "playerCountLbl";
            this.playerCountLbl.Size = new System.Drawing.Size(110, 31);
            this.playerCountLbl.TabIndex = 27;
            this.playerCountLbl.Text = "000000";
            this.playerCountLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IACountLbl
            // 
            this.IACountLbl.AutoSize = true;
            this.IACountLbl.BackColor = System.Drawing.Color.Transparent;
            this.IACountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IACountLbl.ForeColor = System.Drawing.Color.White;
            this.IACountLbl.Location = new System.Drawing.Point(978, 97);
            this.IACountLbl.Name = "IACountLbl";
            this.IACountLbl.Size = new System.Drawing.Size(94, 31);
            this.IACountLbl.TabIndex = 28;
            this.IACountLbl.Text = "00000";
            this.IACountLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IATimer
            // 
            this.IATimer.Enabled = true;
            this.IATimer.Interval = 6000;
            this.IATimer.Tick += new System.EventHandler(this.IATimer_Tick);
            // 
            // raceTimer
            // 
            this.raceTimer.Enabled = true;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // VentanaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.IACountLbl);
            this.Controls.Add(this.playerCountLbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblVel_player);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.CarritoIA);
            this.Controls.Add(this.CarritoPlayer);
            this.Name = "VentanaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaCarrera";
            this.Load += new System.EventHandler(this.VentanaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarritoIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CarritoIA;
        private System.Windows.Forms.PictureBox CarritoPlayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.Label lblVel_player;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label playerCountLbl;
        private System.Windows.Forms.Label IACountLbl;
        private System.Windows.Forms.Timer IATimer;
        private System.Windows.Forms.Timer raceTimer;
    }
}