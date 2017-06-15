namespace Gra
{
    partial class Info_menu
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
            this.graj_info_but = new System.Windows.Forms.Button();
            this.powrot_info_but = new System.Windows.Forms.Button();
            this.infotb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // graj_info_but
            // 
            this.graj_info_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.graj_info_but.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.graj_info_but.Location = new System.Drawing.Point(12, 202);
            this.graj_info_but.Name = "graj_info_but";
            this.graj_info_but.Size = new System.Drawing.Size(124, 33);
            this.graj_info_but.TabIndex = 0;
            this.graj_info_but.Text = "Graj!";
            this.graj_info_but.UseVisualStyleBackColor = false;
            this.graj_info_but.Click += new System.EventHandler(this.graj_info_but_Click);
            // 
            // powrot_info_but
            // 
            this.powrot_info_but.BackColor = System.Drawing.Color.Blue;
            this.powrot_info_but.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.powrot_info_but.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrot_info_but.ForeColor = System.Drawing.SystemColors.Control;
            this.powrot_info_but.Location = new System.Drawing.Point(148, 202);
            this.powrot_info_but.Name = "powrot_info_but";
            this.powrot_info_but.Size = new System.Drawing.Size(124, 33);
            this.powrot_info_but.TabIndex = 4;
            this.powrot_info_but.Text = "Powrót do menu";
            this.powrot_info_but.UseVisualStyleBackColor = false;
            this.powrot_info_but.Click += new System.EventHandler(this.powrot_info_but_Click);
            // 
            // infotb
            // 
            this.infotb.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infotb.Location = new System.Drawing.Point(36, 52);
            this.infotb.Multiline = true;
            this.infotb.Name = "infotb";
            this.infotb.ReadOnly = true;
            this.infotb.Size = new System.Drawing.Size(203, 51);
            this.infotb.TabIndex = 5;
            this.infotb.Text = "To raczej prosty quiz. Dasz radę!";
            this.infotb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infotb.Visible = false;
            // 
            // Info_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gra.Properties.Resources.stare;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.infotb);
            this.Controls.Add(this.powrot_info_but);
            this.Controls.Add(this.graj_info_but);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powodzenia!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button graj_info_but;
        private System.Windows.Forms.Button powrot_info_but;
        private System.Windows.Forms.TextBox infotb;
    }
}