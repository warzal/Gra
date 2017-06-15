namespace Gra
{
    partial class Quiz_wybor
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
            this.wyb_top_but = new System.Windows.Forms.Button();
            this.wyb_PG_but = new System.Windows.Forms.Button();
            this.Wyniki_return_but = new System.Windows.Forms.Button();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // wyb_top_but
            // 
            this.wyb_top_but.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyb_top_but.Location = new System.Drawing.Point(21, 26);
            this.wyb_top_but.Name = "wyb_top_but";
            this.wyb_top_but.Size = new System.Drawing.Size(139, 60);
            this.wyb_top_but.TabIndex = 0;
            this.wyb_top_but.Text = "Topologia";
            this.wyb_top_but.UseVisualStyleBackColor = true;
            this.wyb_top_but.Click += new System.EventHandler(this.wyb_top_but_Click);
            // 
            // wyb_PG_but
            // 
            this.wyb_PG_but.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyb_PG_but.Location = new System.Drawing.Point(230, 26);
            this.wyb_PG_but.Name = "wyb_PG_but";
            this.wyb_PG_but.Size = new System.Drawing.Size(139, 60);
            this.wyb_PG_but.TabIndex = 1;
            this.wyb_PG_but.Text = "PG";
            this.wyb_PG_but.UseVisualStyleBackColor = true;
            this.wyb_PG_but.Click += new System.EventHandler(this.wyb_PG_but_Click);
            // 
            // Wyniki_return_but
            // 
            this.Wyniki_return_but.BackColor = System.Drawing.Color.YellowGreen;
            this.Wyniki_return_but.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Wyniki_return_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyniki_return_but.Location = new System.Drawing.Point(327, 309);
            this.Wyniki_return_but.Name = "Wyniki_return_but";
            this.Wyniki_return_but.Size = new System.Drawing.Size(75, 23);
            this.Wyniki_return_but.TabIndex = 5;
            this.Wyniki_return_but.Text = "Powrót";
            this.Wyniki_return_but.UseVisualStyleBackColor = false;
            // 
            // pcb
            // 
            this.pcb.Location = new System.Drawing.Point(21, 92);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(348, 211);
            this.pcb.TabIndex = 6;
            this.pcb.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // Quiz_wybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(405, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.Wyniki_return_but);
            this.Controls.Add(this.wyb_PG_but);
            this.Controls.Add(this.wyb_top_but);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quiz_wybor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz_wybor";
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wyb_top_but;
        private System.Windows.Forms.Button wyb_PG_but;
        private System.Windows.Forms.Button Wyniki_return_but;
        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.TextBox textBox1;
    }
}