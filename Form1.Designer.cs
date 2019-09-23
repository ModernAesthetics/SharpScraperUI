namespace SharpScraper
{
    partial class Form1
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
            this.animaForm1 = new AnimaForm();
            this.animaButton2 = new AnimaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.animaProgressBar1 = new AnimaProgressBar();
            this.animaButton1 = new AnimaButton();
            this.animaTextBox1 = new AnimaTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.animaForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animaForm1
            // 
            this.animaForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.animaForm1.Controls.Add(this.animaButton2);
            this.animaForm1.Controls.Add(this.label1);
            this.animaForm1.Controls.Add(this.animaProgressBar1);
            this.animaForm1.Controls.Add(this.animaButton1);
            this.animaForm1.Controls.Add(this.animaTextBox1);
            this.animaForm1.Controls.Add(this.richTextBox1);
            this.animaForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animaForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.animaForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.animaForm1.Location = new System.Drawing.Point(0, 0);
            this.animaForm1.Name = "animaForm1";
            this.animaForm1.Size = new System.Drawing.Size(717, 358);
            this.animaForm1.TabIndex = 0;
            this.animaForm1.Text = "SHARP SCRAPER";
            // 
            // animaButton2
            // 
            this.animaButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.animaButton2.FlatAppearance.BorderSize = 0;
            this.animaButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animaButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animaButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.animaButton2.ImageLocation = new System.Drawing.Point(30, 6);
            this.animaButton2.ImageSize = new System.Drawing.Size(14, 14);
            this.animaButton2.Location = new System.Drawing.Point(688, 6);
            this.animaButton2.Margin = new System.Windows.Forms.Padding(0);
            this.animaButton2.Name = "animaButton2";
            this.animaButton2.Size = new System.Drawing.Size(19, 18);
            this.animaButton2.TabIndex = 5;
            this.animaButton2.Text = "x";
            this.animaButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.animaButton2.UseMnemonic = false;
            this.animaButton2.UseVisualStyleBackColor = false;
            this.animaButton2.Click += new System.EventHandler(this.AnimaButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "REGEX";
            // 
            // animaProgressBar1
            // 
            this.animaProgressBar1.Location = new System.Drawing.Point(11, 320);
            this.animaProgressBar1.Name = "animaProgressBar1";
            this.animaProgressBar1.Size = new System.Drawing.Size(614, 23);
            this.animaProgressBar1.TabIndex = 3;
            // 
            // animaButton1
            // 
            this.animaButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.animaButton1.ForeColor = System.Drawing.Color.Gold;
            this.animaButton1.ImageLocation = new System.Drawing.Point(30, 6);
            this.animaButton1.ImageSize = new System.Drawing.Size(14, 14);
            this.animaButton1.Location = new System.Drawing.Point(631, 320);
            this.animaButton1.Name = "animaButton1";
            this.animaButton1.Size = new System.Drawing.Size(75, 23);
            this.animaButton1.TabIndex = 2;
            this.animaButton1.Text = "SCRAPE";
            this.animaButton1.UseVisualStyleBackColor = true;
            // 
            // animaTextBox1
            // 
            this.animaTextBox1.Dark = false;
            this.animaTextBox1.Location = new System.Drawing.Point(11, 44);
            this.animaTextBox1.MaxLength = 32767;
            this.animaTextBox1.MultiLine = false;
            this.animaTextBox1.Name = "animaTextBox1";
            this.animaTextBox1.Numeric = false;
            this.animaTextBox1.ReadOnly = false;
            this.animaTextBox1.Size = new System.Drawing.Size(271, 23);
            this.animaTextBox1.TabIndex = 1;
            this.animaTextBox1.UseSystemPasswordChar = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(11, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(694, 241);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 358);
            this.Controls.Add(this.animaForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.animaForm1.ResumeLayout(false);
            this.animaForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AnimaForm animaForm1;
        private AnimaButton animaButton1;
        private AnimaTextBox animaTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private AnimaButton animaButton2;
        private System.Windows.Forms.Label label1;
        private AnimaProgressBar animaProgressBar1;
    }
}

