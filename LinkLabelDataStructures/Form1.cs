using System.Windows.Forms;

namespace LinkLabelDataStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cDriveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cDriveLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void deitelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deitelLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deitel.com");
        }

        private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notepadLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
