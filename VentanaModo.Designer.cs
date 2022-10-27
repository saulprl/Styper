namespace Styper_v2
{
    partial class VentanaModo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaModo));
            this.label1 = new System.Windows.Forms.Label();
            this.raceBtn = new System.Windows.Forms.Button();
            this.timeTrialBtn = new System.Windows.Forms.Button();
            this.wordsRaceBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
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
            // raceBtn
            // 
            this.raceBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.raceBtn.FlatAppearance.BorderSize = 0;
            this.raceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBtn.ForeColor = System.Drawing.Color.White;
            this.raceBtn.Location = new System.Drawing.Point(436, 382);
            this.raceBtn.Name = "raceBtn";
            this.raceBtn.Size = new System.Drawing.Size(426, 37);
            this.raceBtn.TabIndex = 13;
            this.raceBtn.Text = "Carrera en circuito";
            this.raceBtn.UseVisualStyleBackColor = false;
            this.raceBtn.Click += new System.EventHandler(this.raceBtn_Click);
            // 
            // timeTrialBtn
            // 
            this.timeTrialBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.timeTrialBtn.FlatAppearance.BorderSize = 0;
            this.timeTrialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeTrialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTrialBtn.ForeColor = System.Drawing.Color.White;
            this.timeTrialBtn.Location = new System.Drawing.Point(436, 438);
            this.timeTrialBtn.Name = "timeTrialBtn";
            this.timeTrialBtn.Size = new System.Drawing.Size(426, 37);
            this.timeTrialBtn.TabIndex = 14;
            this.timeTrialBtn.Text = "Contratiempo";
            this.timeTrialBtn.UseVisualStyleBackColor = false;
            this.timeTrialBtn.Click += new System.EventHandler(this.timeTrialBtn_Click);
            // 
            // wordsRaceBtn
            // 
            this.wordsRaceBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.wordsRaceBtn.FlatAppearance.BorderSize = 0;
            this.wordsRaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordsRaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRaceBtn.ForeColor = System.Drawing.Color.White;
            this.wordsRaceBtn.Location = new System.Drawing.Point(436, 491);
            this.wordsRaceBtn.Name = "wordsRaceBtn";
            this.wordsRaceBtn.Size = new System.Drawing.Size(426, 37);
            this.wordsRaceBtn.TabIndex = 15;
            this.wordsRaceBtn.Text = "Carrera de palabras";
            this.wordsRaceBtn.UseVisualStyleBackColor = false;
            this.wordsRaceBtn.Click += new System.EventHandler(this.wordsRaceBtn_Click);
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
            // VentanaModo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.wordsRaceBtn);
            this.Controls.Add(this.timeTrialBtn);
            this.Controls.Add(this.raceBtn);
            this.Controls.Add(this.label1);
            this.Name = "VentanaModo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaModo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button raceBtn;
        private System.Windows.Forms.Button timeTrialBtn;
        private System.Windows.Forms.Button wordsRaceBtn;
        private System.Windows.Forms.Button backButton;
    }
}