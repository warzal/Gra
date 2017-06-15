namespace Gra
{
    partial class Quiz_menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Obrazek = new System.Windows.Forms.PictureBox();
            this.start_but = new System.Windows.Forms.Button();
            this.wyniki_but = new System.Windows.Forms.Button();
            this.wyjdz_but = new System.Windows.Forms.Button();
            this.Music_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // Obrazek
            // 
            this.Obrazek.Image = global::Gra.Properties.Resources.wejscie1;
            this.Obrazek.Location = new System.Drawing.Point(12, 26);
            this.Obrazek.Name = "Obrazek";
            this.Obrazek.Size = new System.Drawing.Size(208, 250);
            this.Obrazek.TabIndex = 0;
            this.Obrazek.TabStop = false;
            // 
            // start_but
            // 
            this.start_but.BackColor = System.Drawing.Color.Yellow;
            this.start_but.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_but.Location = new System.Drawing.Point(259, 66);
            this.start_but.Name = "start_but";
            this.start_but.Size = new System.Drawing.Size(122, 44);
            this.start_but.TabIndex = 1;
            this.start_but.Text = "Rozpocznij grę";
            this.start_but.UseVisualStyleBackColor = false;
            this.start_but.Click += new System.EventHandler(this.start_but_Click);
            // 
            // wyniki_but
            // 
            this.wyniki_but.BackColor = System.Drawing.Color.Cornsilk;
            this.wyniki_but.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyniki_but.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wyniki_but.Location = new System.Drawing.Point(259, 144);
            this.wyniki_but.Name = "wyniki_but";
            this.wyniki_but.Size = new System.Drawing.Size(122, 44);
            this.wyniki_but.TabIndex = 2;
            this.wyniki_but.Text = "Podziękowania";
            this.wyniki_but.UseVisualStyleBackColor = false;
            this.wyniki_but.Click += new System.EventHandler(this.wyniki_but_Click);
            // 
            // wyjdz_but
            // 
            this.wyjdz_but.BackColor = System.Drawing.Color.Crimson;
            this.wyjdz_but.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyjdz_but.Location = new System.Drawing.Point(259, 222);
            this.wyjdz_but.Name = "wyjdz_but";
            this.wyjdz_but.Size = new System.Drawing.Size(122, 44);
            this.wyjdz_but.TabIndex = 3;
            this.wyjdz_but.Text = "Wyjdź";
            this.wyjdz_but.UseVisualStyleBackColor = false;
            this.wyjdz_but.Click += new System.EventHandler(this.wyjdz_but_Click);
            // 
            // Music_but
            // 
            this.Music_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Music_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Music_but.Location = new System.Drawing.Point(351, 2);
            this.Music_but.Name = "Music_but";
            this.Music_but.Size = new System.Drawing.Size(62, 48);
            this.Music_but.TabIndex = 4;
            this.Music_but.Text = "Muzyka";
            this.Music_but.UseVisualStyleBackColor = false;
            this.Music_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(351, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wyłącz muzykę";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quiz_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gra.Properties.Resources.torus_1000;
            this.ClientSize = new System.Drawing.Size(425, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Music_but);
            this.Controls.Add(this.wyjdz_but);
            this.Controls.Add(this.wyniki_but);
            this.Controls.Add(this.start_but);
            this.Controls.Add(this.Obrazek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Quiz_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Obrazek;
        private System.Windows.Forms.Button start_but;
        private System.Windows.Forms.Button wyniki_but;
        private System.Windows.Forms.Button wyjdz_but;
        private System.Windows.Forms.Button Music_but;
        private System.Windows.Forms.Button button1;
    }
}

