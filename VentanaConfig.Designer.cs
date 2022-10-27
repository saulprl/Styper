namespace Styper_v2
{
    partial class VentanaConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Mute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 108);
            this.label1.TabIndex = 4;
            this.label1.Text = "Styper";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MediumBlue;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(436, 543);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(426, 37);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.trackBar1.Location = new System.Drawing.Point(436, 394);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(426, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Mute
            // 
            this.Mute.BackColor = System.Drawing.SystemColors.Highlight;
            this.Mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mute.BackgroundImage")));
            this.Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mute.Location = new System.Drawing.Point(617, 309);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(52, 45);
            this.Mute.TabIndex = 18;
            this.Mute.UseVisualStyleBackColor = false;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // VentanaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "VentanaConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaModo";
            this.Load += new System.EventHandler(this.VentanaConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Mute;
    }
}