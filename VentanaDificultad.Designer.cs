namespace Styper_v2
{
    partial class VentanaDificultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDificultad));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 5;
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
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.hardBtn.FlatAppearance.BorderSize = 0;
            this.hardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.ForeColor = System.Drawing.Color.White;
            this.hardBtn.Location = new System.Drawing.Point(436, 491);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(426, 37);
            this.hardBtn.TabIndex = 19;
            this.hardBtn.Text = "Difícil";
            this.hardBtn.UseVisualStyleBackColor = false;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // mediumBtn
            // 
            this.mediumBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.mediumBtn.FlatAppearance.BorderSize = 0;
            this.mediumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.ForeColor = System.Drawing.Color.White;
            this.mediumBtn.Location = new System.Drawing.Point(436, 438);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(426, 37);
            this.mediumBtn.TabIndex = 18;
            this.mediumBtn.Text = "Normal";
            this.mediumBtn.UseVisualStyleBackColor = false;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.easyBtn.FlatAppearance.BorderSize = 0;
            this.easyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBtn.ForeColor = System.Drawing.Color.White;
            this.easyBtn.Location = new System.Drawing.Point(436, 382);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(426, 37);
            this.easyBtn.TabIndex = 17;
            this.easyBtn.Text = "Fácil";
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // VentanaDificultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hardBtn);
            this.Controls.Add(this.mediumBtn);
            this.Controls.Add(this.easyBtn);
            this.Controls.Add(this.label1);
            this.Name = "VentanaDificultad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaDificultad";
            this.Load += new System.EventHandler(this.VentanaDificultad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button easyBtn;
    }
}