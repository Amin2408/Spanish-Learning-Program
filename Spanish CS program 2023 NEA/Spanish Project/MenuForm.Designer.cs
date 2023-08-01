
namespace Spanish_Project
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadingButton = new System.Windows.Forms.Button();
            this.ListeningButton = new System.Windows.Forms.Button();
            this.WritingButton = new System.Windows.Forms.Button();
            this.WritingCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.englishToSpanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transButton = new System.Windows.Forms.Button();
            this.Wdesc = new System.Windows.Forms.Button();
            this.Adesc = new System.Windows.Forms.Button();
            this.Vdesc = new System.Windows.Forms.Button();
            this.ContentsButton = new System.Windows.Forms.Button();
            this.ReadingCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fillInTheBlanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotTheErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentsCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grammarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WritingCM.SuspendLayout();
            this.ReadingCM.SuspendLayout();
            this.ContentsCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(646, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spanish Learning Program";
            // 
            // ReadingButton
            // 
            this.ReadingButton.BackColor = System.Drawing.SystemColors.Info;
            this.ReadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadingButton.Location = new System.Drawing.Point(90, 420);
            this.ReadingButton.Name = "ReadingButton";
            this.ReadingButton.Size = new System.Drawing.Size(495, 185);
            this.ReadingButton.TabIndex = 1;
            this.ReadingButton.Text = "Reading";
            this.ReadingButton.UseVisualStyleBackColor = false;
            this.ReadingButton.Click += new System.EventHandler(this.ReadingButton_Click);
            this.ReadingButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReadingButton_MouseClick);
            // 
            // ListeningButton
            // 
            this.ListeningButton.BackColor = System.Drawing.SystemColors.Info;
            this.ListeningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeningButton.Location = new System.Drawing.Point(90, 629);
            this.ListeningButton.Name = "ListeningButton";
            this.ListeningButton.Size = new System.Drawing.Size(495, 185);
            this.ListeningButton.TabIndex = 2;
            this.ListeningButton.Text = "Listening";
            this.ListeningButton.UseVisualStyleBackColor = false;
            this.ListeningButton.Click += new System.EventHandler(this.ListeningButton_Click);
            // 
            // WritingButton
            // 
            this.WritingButton.BackColor = System.Drawing.SystemColors.Info;
            this.WritingButton.ContextMenuStrip = this.WritingCM;
            this.WritingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritingButton.Location = new System.Drawing.Point(90, 211);
            this.WritingButton.Name = "WritingButton";
            this.WritingButton.Size = new System.Drawing.Size(495, 185);
            this.WritingButton.TabIndex = 3;
            this.WritingButton.Text = "Writing";
            this.WritingButton.UseVisualStyleBackColor = false;
            this.WritingButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WritingButton_MouseClick);
            // 
            // WritingCM
            // 
            this.WritingCM.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.WritingCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToSpanishToolStripMenuItem,
            this.spanishToEnglishToolStripMenuItem});
            this.WritingCM.Name = "contextMenuStrip1";
            this.WritingCM.Size = new System.Drawing.Size(171, 48);
            this.WritingCM.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // englishToSpanishToolStripMenuItem
            // 
            this.englishToSpanishToolStripMenuItem.Name = "englishToSpanishToolStripMenuItem";
            this.englishToSpanishToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.englishToSpanishToolStripMenuItem.Text = "English to Spanish";
            this.englishToSpanishToolStripMenuItem.Click += new System.EventHandler(this.englishToSpanishToolStripMenuItem_Click);
            // 
            // spanishToEnglishToolStripMenuItem
            // 
            this.spanishToEnglishToolStripMenuItem.Name = "spanishToEnglishToolStripMenuItem";
            this.spanishToEnglishToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.spanishToEnglishToolStripMenuItem.Text = "Spanish to English";
            this.spanishToEnglishToolStripMenuItem.Click += new System.EventHandler(this.spanishToEnglishToolStripMenuItem_Click);
            // 
            // transButton
            // 
            this.transButton.BackColor = System.Drawing.SystemColors.Info;
            this.transButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transButton.Location = new System.Drawing.Point(1142, 211);
            this.transButton.Name = "transButton";
            this.transButton.Size = new System.Drawing.Size(415, 164);
            this.transButton.TabIndex = 4;
            this.transButton.Text = "Translator";
            this.transButton.UseVisualStyleBackColor = false;
            this.transButton.Click += new System.EventHandler(this.transButton_Click);
            // 
            // Wdesc
            // 
            this.Wdesc.BackColor = System.Drawing.Color.Salmon;
            this.Wdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wdesc.Location = new System.Drawing.Point(745, 211);
            this.Wdesc.Name = "Wdesc";
            this.Wdesc.Size = new System.Drawing.Size(237, 175);
            this.Wdesc.TabIndex = 5;
            this.Wdesc.Text = "How \'written learning\' works?";
            this.Wdesc.UseVisualStyleBackColor = false;
            this.Wdesc.Click += new System.EventHandler(this.Wdesc_Click);
            // 
            // Adesc
            // 
            this.Adesc.BackColor = System.Drawing.Color.Salmon;
            this.Adesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adesc.Location = new System.Drawing.Point(745, 629);
            this.Adesc.Name = "Adesc";
            this.Adesc.Size = new System.Drawing.Size(237, 175);
            this.Adesc.TabIndex = 6;
            this.Adesc.Text = "How \'Listening\' works?";
            this.Adesc.UseVisualStyleBackColor = false;
            // 
            // Vdesc
            // 
            this.Vdesc.BackColor = System.Drawing.Color.Salmon;
            this.Vdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vdesc.Location = new System.Drawing.Point(745, 420);
            this.Vdesc.Name = "Vdesc";
            this.Vdesc.Size = new System.Drawing.Size(237, 175);
            this.Vdesc.TabIndex = 7;
            this.Vdesc.Text = "How \'Reading\' works?";
            this.Vdesc.UseVisualStyleBackColor = false;
           
            // 
            // ContentsButton
            // 
            this.ContentsButton.BackColor = System.Drawing.Color.Silver;
            this.ContentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentsButton.Location = new System.Drawing.Point(1142, 581);
            this.ContentsButton.Name = "ContentsButton";
            this.ContentsButton.Size = new System.Drawing.Size(415, 179);
            this.ContentsButton.TabIndex = 8;
            this.ContentsButton.Text = "Contents";
            this.ContentsButton.UseVisualStyleBackColor = false;
            this.ContentsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContentsButton_MouseClick);
            // 
            // ReadingCM
            // 
            this.ReadingCM.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ReadingCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillInTheBlanksToolStripMenuItem,
            this.spotTheErrorToolStripMenuItem});
            this.ReadingCM.Name = "contextMenuStrip2";
            this.ReadingCM.Size = new System.Drawing.Size(163, 48);
            this.ReadingCM.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // fillInTheBlanksToolStripMenuItem
            // 
            this.fillInTheBlanksToolStripMenuItem.Name = "fillInTheBlanksToolStripMenuItem";
            this.fillInTheBlanksToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fillInTheBlanksToolStripMenuItem.Text = "Fill in the blanks ";
            this.fillInTheBlanksToolStripMenuItem.Click += new System.EventHandler(this.fillInTheBlanksToolStripMenuItem_Click);
            // 
            // spotTheErrorToolStripMenuItem
            // 
            this.spotTheErrorToolStripMenuItem.Name = "spotTheErrorToolStripMenuItem";
            this.spotTheErrorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spotTheErrorToolStripMenuItem.Text = "Spot the error";
            this.spotTheErrorToolStripMenuItem.Click += new System.EventHandler(this.spotTheErrorToolStripMenuItem_Click);
            // 
            // ContentsCM
            // 
            this.ContentsCM.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ContentsCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grammarToolStripMenuItem,
            this.vocabularyToolStripMenuItem});
            this.ContentsCM.Name = "contextMenuStrip3";
            this.ContentsCM.Size = new System.Drawing.Size(133, 48);
            this.ContentsCM.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // grammarToolStripMenuItem
            // 
            this.grammarToolStripMenuItem.Name = "grammarToolStripMenuItem";
            this.grammarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.grammarToolStripMenuItem.Text = "Grammar";
            this.grammarToolStripMenuItem.Click += new System.EventHandler(this.grammarToolStripMenuItem_Click);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.vocabularyToolStripMenuItem.Text = "Vocabulary";
            this.vocabularyToolStripMenuItem.Click += new System.EventHandler(this.vocabularyToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spanish_Project.Properties.Resources.spain_flag_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.ContentsButton);
            this.Controls.Add(this.Vdesc);
            this.Controls.Add(this.Adesc);
            this.Controls.Add(this.Wdesc);
            this.Controls.Add(this.transButton);
            this.Controls.Add(this.WritingButton);
            this.Controls.Add(this.ListeningButton);
            this.Controls.Add(this.ReadingButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poor Richard", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuForm";
            this.Text = "Spanish Learning";
            this.WritingCM.ResumeLayout(false);
            this.ReadingCM.ResumeLayout(false);
            this.ContentsCM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadingButton;
        private System.Windows.Forms.Button ListeningButton;
        private System.Windows.Forms.Button WritingButton;
        private System.Windows.Forms.Button transButton;
        private System.Windows.Forms.Button Wdesc;
        private System.Windows.Forms.Button Adesc;
        private System.Windows.Forms.Button Vdesc;
        private System.Windows.Forms.Button ContentsButton;
        private System.Windows.Forms.ContextMenuStrip WritingCM;
        private System.Windows.Forms.ToolStripMenuItem englishToSpanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToEnglishToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ReadingCM;
        private System.Windows.Forms.ToolStripMenuItem fillInTheBlanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotTheErrorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContentsCM;
        private System.Windows.Forms.ToolStripMenuItem grammarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
    }
}

