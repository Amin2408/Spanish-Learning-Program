namespace Spanish_Project
{
    partial class SpotError
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
            this.STElabel = new System.Windows.Forms.Label();
            this.opt1btnSTE = new System.Windows.Forms.Button();
            this.opt2btnSTE = new System.Windows.Forms.Button();
            this.opt3btnSTE = new System.Windows.Forms.Button();
            this.opt4btnSTE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STElabel
            // 
            this.STElabel.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STElabel.Location = new System.Drawing.Point(11, 40);
            this.STElabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.STElabel.Name = "STElabel";
            this.STElabel.Size = new System.Drawing.Size(1006, 170);
            this.STElabel.TabIndex = 0;
            this.STElabel.Text = "STElabel";
            this.STElabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // opt1btnSTE
            // 
            this.opt1btnSTE.BackColor = System.Drawing.Color.Silver;
            this.opt1btnSTE.Location = new System.Drawing.Point(98, 267);
            this.opt1btnSTE.Margin = new System.Windows.Forms.Padding(2);
            this.opt1btnSTE.Name = "opt1btnSTE";
            this.opt1btnSTE.Size = new System.Drawing.Size(165, 83);
            this.opt1btnSTE.TabIndex = 1;
            this.opt1btnSTE.Text = "button1";
            this.opt1btnSTE.UseVisualStyleBackColor = false;
            this.opt1btnSTE.Click += new System.EventHandler(this.button1_Click);
            // 
            // opt2btnSTE
            // 
            this.opt2btnSTE.BackColor = System.Drawing.Color.Silver;
            this.opt2btnSTE.Location = new System.Drawing.Point(98, 430);
            this.opt2btnSTE.Margin = new System.Windows.Forms.Padding(2);
            this.opt2btnSTE.Name = "opt2btnSTE";
            this.opt2btnSTE.Size = new System.Drawing.Size(165, 83);
            this.opt2btnSTE.TabIndex = 2;
            this.opt2btnSTE.Text = "button2";
            this.opt2btnSTE.UseVisualStyleBackColor = false;
            this.opt2btnSTE.Click += new System.EventHandler(this.button2_Click);
            // 
            // opt3btnSTE
            // 
            this.opt3btnSTE.BackColor = System.Drawing.Color.Silver;
            this.opt3btnSTE.Location = new System.Drawing.Point(471, 267);
            this.opt3btnSTE.Margin = new System.Windows.Forms.Padding(2);
            this.opt3btnSTE.Name = "opt3btnSTE";
            this.opt3btnSTE.Size = new System.Drawing.Size(165, 83);
            this.opt3btnSTE.TabIndex = 3;
            this.opt3btnSTE.Text = "button3";
            this.opt3btnSTE.UseVisualStyleBackColor = false;
            this.opt3btnSTE.Click += new System.EventHandler(this.button3_Click);
            // 
            // opt4btnSTE
            // 
            this.opt4btnSTE.BackColor = System.Drawing.Color.Silver;
            this.opt4btnSTE.Location = new System.Drawing.Point(471, 430);
            this.opt4btnSTE.Margin = new System.Windows.Forms.Padding(2);
            this.opt4btnSTE.Name = "opt4btnSTE";
            this.opt4btnSTE.Size = new System.Drawing.Size(165, 83);
            this.opt4btnSTE.TabIndex = 4;
            this.opt4btnSTE.Text = "button4";
            this.opt4btnSTE.UseVisualStyleBackColor = false;
            this.opt4btnSTE.Click += new System.EventHandler(this.button4_Click);
            // 
            // SpotError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1071, 629);
            this.Controls.Add(this.opt4btnSTE);
            this.Controls.Add(this.opt3btnSTE);
            this.Controls.Add(this.opt2btnSTE);
            this.Controls.Add(this.opt1btnSTE);
            this.Controls.Add(this.STElabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpotError";
            this.Text = "Spot The Error";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label STElabel;
        private System.Windows.Forms.Button opt1btnSTE;
        private System.Windows.Forms.Button opt2btnSTE;
        private System.Windows.Forms.Button opt3btnSTE;
        private System.Windows.Forms.Button opt4btnSTE;
    }
}