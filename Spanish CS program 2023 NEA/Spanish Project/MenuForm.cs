using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanish_Project
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            
        }       

        public void ListeningButton_Click(object sender, EventArgs e)
        {
            AuditoryForm auditoryWindow = new AuditoryForm();
            auditoryWindow.ShowDialog(); 
        }

        private void ReadingButton_Click(object sender, EventArgs e)
        {
            
        }

        private void transButton_Click(object sender, EventArgs e)
        {
            translator translatorWindow = new translator();
            translatorWindow.ShowDialog();
        }

        private void Wdesc_Click(object sender, EventArgs e)
        {
            HWLW WLexplanation = new HWLW();
            WLexplanation.ShowDialog();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void WritingButton_MouseClick(object sender, MouseEventArgs e) // when the writing button is clicked, show the context menu
        {
            if (e.Button == MouseButtons.Left)              // shows the context menu where the cursor was clicked, but it will be on the reading because it is coded under the reading function
            {
                WritingCM.Show(Cursor.Position);
            }
        }

        private void englishToSpanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngToSp e2s = new EngToSp();
            e2s.ShowDialog();
            
        }

        private void spanishToEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpToEng s2e = new SpToEng(); // when the option from context menu is chosen, the form for it is opened
            s2e.ShowDialog();
        }

        private void fillInTheBlanksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FITB fillBlanks = new FITB();
            fillBlanks.ShowDialog();
        }
        
        private void spotTheErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpotError spErr = new SpotError();
            spErr.ShowDialog();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ReadingButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReadingCM.Show(Cursor.Position); // shows the context menu where the cursor was clicked, but it will be on the reading because it is coded under the reading function
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ContentsButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ContentsCM.Show(Cursor.Position);   // shows the context menu where the cursor was clicked, but it will be on the reading because it is coded under the reading function
            }
        }

        private void grammarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grammar grmmrForm = new Grammar();
            grmmrForm.ShowDialog();             
        }

        private void vocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vocab vocabForm = new vocab();
            vocabForm.ShowDialog(); 
        }

        
    }
}
