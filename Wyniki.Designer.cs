namespace Gra
{
    partial class Wyniki_menu
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
            this.Wyniki_best_tb1 = new System.Windows.Forms.TextBox();
            this.Wyniki_ost_tb = new System.Windows.Forms.TextBox();
            this.BestWynik_user_tb = new System.Windows.Forms.TextBox();
            this.LastWynik_user_tb = new System.Windows.Forms.TextBox();
            this.Wyniki_return_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wyniki_best_tb1
            // 
            this.Wyniki_best_tb1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyniki_best_tb1.Location = new System.Drawing.Point(30, 28);
            this.Wyniki_best_tb1.Name = "Wyniki_best_tb1";
            this.Wyniki_best_tb1.ReadOnly = true;
            this.Wyniki_best_tb1.Size = new System.Drawing.Size(207, 29);
            this.Wyniki_best_tb1.TabIndex = 0;
            this.Wyniki_best_tb1.Text = "Najlepszy wynik:";
            this.Wyniki_best_tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wyniki_ost_tb
            // 
            this.Wyniki_ost_tb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyniki_ost_tb.Location = new System.Drawing.Point(30, 132);
            this.Wyniki_ost_tb.Name = "Wyniki_ost_tb";
            this.Wyniki_ost_tb.ReadOnly = true;
            this.Wyniki_ost_tb.Size = new System.Drawing.Size(207, 29);
            this.Wyniki_ost_tb.TabIndex = 1;
            this.Wyniki_ost_tb.Text = "Ostatni wynik:";
            this.Wyniki_ost_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BestWynik_user_tb
            // 
            this.BestWynik_user_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BestWynik_user_tb.Location = new System.Drawing.Point(67, 85);
            this.BestWynik_user_tb.Name = "BestWynik_user_tb";
            this.BestWynik_user_tb.Size = new System.Drawing.Size(124, 26);
            this.BestWynik_user_tb.TabIndex = 2;
            this.BestWynik_user_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastWynik_user_tb
            // 
            this.LastWynik_user_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastWynik_user_tb.Location = new System.Drawing.Point(67, 193);
            this.LastWynik_user_tb.Name = "LastWynik_user_tb";
            this.LastWynik_user_tb.Size = new System.Drawing.Size(124, 26);
            this.LastWynik_user_tb.TabIndex = 3;
            this.LastWynik_user_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wyniki_return_but
            // 
            this.Wyniki_return_but.BackColor = System.Drawing.Color.Brown;
            this.Wyniki_return_but.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Wyniki_return_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyniki_return_but.Location = new System.Drawing.Point(186, 226);
            this.Wyniki_return_but.Name = "Wyniki_return_but";
            this.Wyniki_return_but.Size = new System.Drawing.Size(75, 23);
            this.Wyniki_return_but.TabIndex = 4;
            this.Wyniki_return_but.Text = "Powrót";
            this.Wyniki_return_but.UseVisualStyleBackColor = false;
            this.Wyniki_return_but.Click += new System.EventHandler(this.Wyniki_return_but_Click);
            // 
            // Wyniki_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gra.Properties.Resources.puchar;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Wyniki_return_but);
            this.Controls.Add(this.LastWynik_user_tb);
            this.Controls.Add(this.BestWynik_user_tb);
            this.Controls.Add(this.Wyniki_ost_tb);
            this.Controls.Add(this.Wyniki_best_tb1);
            this.Name = "Wyniki_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyniki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Wyniki_best_tb1;
        private System.Windows.Forms.TextBox Wyniki_ost_tb;
        private System.Windows.Forms.TextBox BestWynik_user_tb;
        private System.Windows.Forms.TextBox LastWynik_user_tb;
        private System.Windows.Forms.Button Wyniki_return_but;
    }
}