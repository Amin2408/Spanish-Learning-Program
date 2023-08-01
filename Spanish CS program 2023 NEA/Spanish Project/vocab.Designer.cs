namespace Spanish_Project
{
    partial class vocab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vocab));
            this.VocabText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VocabText
            // 
            this.VocabText.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VocabText.Location = new System.Drawing.Point(45, 31);
            this.VocabText.Name = "VocabText";
            this.VocabText.Size = new System.Drawing.Size(707, 549);
            this.VocabText.TabIndex = 0;
            this.VocabText.Text = resources.GetString("VocabText.Text");
            // 
            // vocab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.VocabText);
            this.Name = "vocab";
            this.Text = "vocab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VocabText;
    }
}