
namespace CS056Semafor
{
    partial class CS056Semafor
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.semaforTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zapnoutButton = new System.Windows.Forms.Button();
            this.vypnoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // semaforTimer
            // 
            this.semaforTimer.Enabled = true;
            this.semaforTimer.Interval = 50;
            this.semaforTimer.Tick += new System.EventHandler(this.semaforTimer_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox4.Location = new System.Drawing.Point(78, 286);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox2.Location = new System.Drawing.Point(78, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS056Semafor.Properties.Resources.svetloVypnute;
            this.pictureBox1.Location = new System.Drawing.Point(78, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // zapnoutButton
            // 
            this.zapnoutButton.Location = new System.Drawing.Point(343, 173);
            this.zapnoutButton.Name = "zapnoutButton";
            this.zapnoutButton.Size = new System.Drawing.Size(75, 23);
            this.zapnoutButton.TabIndex = 5;
            this.zapnoutButton.Text = "Zapnout";
            this.zapnoutButton.UseVisualStyleBackColor = true;
            this.zapnoutButton.Click += new System.EventHandler(this.zapnoutButton_Click);
            // 
            // vypnoutButton
            // 
            this.vypnoutButton.Location = new System.Drawing.Point(474, 173);
            this.vypnoutButton.Name = "vypnoutButton";
            this.vypnoutButton.Size = new System.Drawing.Size(75, 23);
            this.vypnoutButton.TabIndex = 6;
            this.vypnoutButton.Text = "Vypnout";
            this.vypnoutButton.UseVisualStyleBackColor = true;
            this.vypnoutButton.Click += new System.EventHandler(this.vypnoutButton_Click);
            // 
            // CS056Semafor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vypnoutButton);
            this.Controls.Add(this.zapnoutButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CS056Semafor";
            this.Text = "CS056 Semafor - Miler Vojtěch";
            this.Load += new System.EventHandler(this.CS056Semafor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer semaforTimer;
        private System.Windows.Forms.Button zapnoutButton;
        private System.Windows.Forms.Button vypnoutButton;
    }
}

