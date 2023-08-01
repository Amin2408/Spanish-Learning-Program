namespace Spanish_Project
{
    partial class Grammar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grammar));
            this.grammarText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grammarText
            // 
            this.grammarText.BackColor = System.Drawing.SystemColors.Control;
            this.grammarText.Font = new System.Drawing.Font("Sprocket BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammarText.Location = new System.Drawing.Point(36, 33);
            this.grammarText.Name = "grammarText";
            this.grammarText.Size = new System.Drawing.Size(821, 713);
            this.grammarText.TabIndex = 0;
            this.grammarText.Text = resources.GetString("grammarText.Text");
            // 
            // Grammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(865, 753);
            this.Controls.Add(this.grammarText);
            this.Name = "Grammar";
            this.Text = "Grammar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label grammarText;
    }
}