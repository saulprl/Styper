namespace Styper_v2
{
    partial class VentanaContrarreloj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaContrarreloj));
            this.wordsLbl = new System.Windows.Forms.Label();
            this.CarritoIA = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoIA)).BeginInit();
            this.SuspendLayout();
            // 
            // wordsLbl
            // 
            this.wordsLbl.AutoSize = true;
            this.wordsLbl.BackColor = System.Drawing.Color.Transparent;
            this.wordsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsLbl.ForeColor = System.Drawing.Color.White;
            this.wordsLbl.Location = new System.Drawing.Point(12, 12);
            this.wordsLbl.Name = "wordsLbl";
            this.wordsLbl.Size = new System.Drawing.Size(99, 31);
            this.wordsLbl.TabIndex = 13;
            this.wordsLbl.Text = "Styper";
            // 
            // CarritoIA
            // 
            this.CarritoIA.BackColor = System.Drawing.Color.Transparent;
            this.CarritoIA.Location = new System.Drawing.Point(12, 474);
            this.CarritoIA.Name = "CarritoIA";
            this.CarritoIA.Size = new System.Drawing.Size(100, 50);
            this.CarritoIA.TabIndex = 20;
            this.CarritoIA.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(564, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
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
            this.label2.TabIndex = 22;
            this.label2.Text = "Palabra";
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.BackColor = System.Drawing.Color.Transparent;
            this.lblpalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpalabra.ForeColor = System.Drawing.Color.White;
            this.lblpalabra.Location = new System.Drawing.Point(564, 380);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(0, 24);
            this.lblpalabra.TabIndex = 21;
            this.lblpalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Enabled = true;
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // countdownLbl
            // 
            this.countdownLbl.AutoSize = true;
            this.countdownLbl.BackColor = System.Drawing.Color.Transparent;
            this.countdownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLbl.ForeColor = System.Drawing.Color.White;
            this.countdownLbl.Location = new System.Drawing.Point(564, 29);
            this.countdownLbl.Name = "countdownLbl";
            this.countdownLbl.Size = new System.Drawing.Size(0, 25);
            this.countdownLbl.TabIndex = 24;
            this.countdownLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1220, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 23);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // VentanaContrarreloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.countdownLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.CarritoIA);
            this.Controls.Add(this.wordsLbl);
            this.Name = "VentanaContrarreloj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaContrarreloj";
            this.Load += new System.EventHandler(this.VentanaContrarreloj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarritoIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordsLbl;
        private System.Windows.Forms.PictureBox CarritoIA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label countdownLbl;
        private System.Windows.Forms.Button closeBtn;
    }
}