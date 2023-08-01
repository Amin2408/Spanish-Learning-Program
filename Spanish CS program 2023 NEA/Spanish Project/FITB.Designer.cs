namespace Spanish_Project
{
    partial class FITB
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
            this.FITBlbl = new System.Windows.Forms.Label();
            this.FITBbtn1 = new System.Windows.Forms.Button();
            this.FITBbtn2 = new System.Windows.Forms.Button();
            this.FITBbtn3 = new System.Windows.Forms.Button();
            this.FITBbtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FITBlbl
            // 
            this.FITBlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FITBlbl.Location = new System.Drawing.Point(59, 27);
            this.FITBlbl.Name = "FITBlbl";
            this.FITBlbl.Size = new System.Drawing.Size(685, 131);
            this.FITBlbl.TabIndex = 0;
            this.FITBlbl.Text = "FITBlabel";
            this.FITBlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // FITBbtn1
            // 
            this.FITBbtn1.Location = new System.Drawing.Point(81, 196);
            this.FITBbtn1.Name = "FITBbtn1";
            this.FITBbtn1.Size = new System.Drawing.Size(144, 65);
            this.FITBbtn1.TabIndex = 1;
            this.FITBbtn1.Text = "button1";
            this.FITBbtn1.UseVisualStyleBackColor = true;
            this.FITBbtn1.Click += new System.EventHandler(this.FITBbtn1_Click);
            // 
            // FITBbtn2
            // 
            this.FITBbtn2.Location = new System.Drawing.Point(478, 196);
            this.FITBbtn2.Name = "FITBbtn2";
            this.FITBbtn2.Size = new System.Drawing.Size(134, 65);
            this.FITBbtn2.TabIndex = 2;
            this.FITBbtn2.Text = "button2";
            this.FITBbtn2.UseVisualStyleBackColor = true;
            this.FITBbtn2.Click += new System.EventHandler(this.FITBbtn2_Click);
            // 
            // FITBbtn3
            // 
            this.FITBbtn3.Location = new System.Drawing.Point(81, 312);
            this.FITBbtn3.Name = "FITBbtn3";
            this.FITBbtn3.Size = new System.Drawing.Size(144, 69);
            this.FITBbtn3.TabIndex = 3;
            this.FITBbtn3.Text = "button3";
            this.FITBbtn3.UseVisualStyleBackColor = true;
            this.FITBbtn3.Click += new System.EventHandler(this.FITBbtn3_Click);
            // 
            // FITBbtn4
            // 
            this.FITBbtn4.Location = new System.Drawing.Point(478, 312);
            this.FITBbtn4.Name = "FITBbtn4";
            this.FITBbtn4.Size = new System.Drawing.Size(134, 69);
            this.FITBbtn4.TabIndex = 4;
            this.FITBbtn4.Text = "button4";
            this.FITBbtn4.UseVisualStyleBackColor = true;
            this.FITBbtn4.Click += new System.EventHandler(this.FITBbtn4_Click);
            // 
            // FITB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FITBbtn4);
            this.Controls.Add(this.FITBbtn3);
            this.Controls.Add(this.FITBbtn2);
            this.Controls.Add(this.FITBbtn1);
            this.Controls.Add(this.FITBlbl);
            this.Name = "FITB";
            this.Text = "FITB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FITBlbl;
        private System.Windows.Forms.Button FITBbtn1;
        private System.Windows.Forms.Button FITBbtn2;
        private System.Windows.Forms.Button FITBbtn3;
        private System.Windows.Forms.Button FITBbtn4;
    }
}