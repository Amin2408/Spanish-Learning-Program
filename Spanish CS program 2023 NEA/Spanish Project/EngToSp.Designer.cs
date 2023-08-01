
namespace Spanish_Project
{
    partial class EngToSp
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
            this.qsLbl = new System.Windows.Forms.Label();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.userInpBox = new System.Windows.Forms.TextBox();
            this.TransFollowing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qsLbl
            // 
            this.qsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.qsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qsLbl.Location = new System.Drawing.Point(55, 235);
            this.qsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qsLbl.Name = "qsLbl";
            this.qsLbl.Size = new System.Drawing.Size(654, 40);
            this.qsLbl.TabIndex = 0;
            this.qsLbl.Text = "Question";
            this.qsLbl.Click += new System.EventHandler(this.qsLbl_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nxtBtn.Location = new System.Drawing.Point(602, 352);
            this.nxtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(116, 37);
            this.nxtBtn.TabIndex = 2;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = false;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_click);
            // 
            // userInpBox
            // 
            this.userInpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userInpBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userInpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInpBox.Location = new System.Drawing.Point(55, 289);
            this.userInpBox.Margin = new System.Windows.Forms.Padding(2);
            this.userInpBox.MaximumSize = new System.Drawing.Size(1002, 2000);
            this.userInpBox.Name = "userInpBox";
            this.userInpBox.Size = new System.Drawing.Size(654, 32);
            this.userInpBox.TabIndex = 3;
            // 
            // TransFollowing
            // 
            this.TransFollowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TransFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransFollowing.Location = new System.Drawing.Point(55, 43);
            this.TransFollowing.Name = "TransFollowing";
            this.TransFollowing.ReadOnly = true;
            this.TransFollowing.Size = new System.Drawing.Size(672, 80);
            this.TransFollowing.TabIndex = 4;
            this.TransFollowing.Text = "Translate the following ";
            // 
            // EngToSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(783, 424);
            this.Controls.Add(this.TransFollowing);
            this.Controls.Add(this.userInpBox);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.qsLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EngToSp";
            this.Text = "English To Spanish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qsLbl;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.TextBox userInpBox;
        private System.Windows.Forms.TextBox TransFollowing;
    }
}