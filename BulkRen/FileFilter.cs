using System;
using System.Windows.Forms;

namespace BulkRen
{
    public partial class FileFilter : Form
    {
        public FileFilter()
        {
            InitializeComponent();
        }

        internal string IncludePrefix1 = "*";
        internal string IncludePrefix2;
        internal string IncludePrefix3;
        internal string IncludeSufix1 = "*";
        internal string IncludeSufix2;
        internal string IncludeSufix3;
        internal string ExcludePrefix1;
        internal string ExcludePrefix2;
        internal string ExcludePrefix3;
        internal string ExcludeSufix1;
        internal string ExcludeSufix2;
        internal string ExcludeSufix3;
        private bool Saved = false;

        public void Filtersetup()
        {
            Include1PrefixBox.Focus();
        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            Saved = false;
            Hide();
           // Form1.Show();
        }

        public string RemoveDot(string S)
        {
            Lib L = new Lib();
            if (S != "")
            {
                if (S.Length > 1)
                {
                    if (L.Left(S, 1) == ".")
                        S = L.Right(S, S.Length - 1);
                }
                else if (S == ".")
                    S = "";
            }

            return S;
        }


        private void SaveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Saved = true;
            if (Include1CheckBox.Checked)
            {
                IncludePrefix1 = Include1PrefixBox.Text;
                IncludeSufix1 = RemoveDot(Include1SufixBox.Text);
            }
            if (Include2CheckBox.Checked)
            {
                IncludePrefix2 = Include2PrefixBox.Text;
                IncludeSufix2 = Include2SufixBox.Text;
            }
            if (Include3CheckBox.Checked)
            {
                IncludePrefix3 = Include3PrefixBox.Text;
                IncludeSufix3 = Include3SufixBox.Text;
            }

            if (Exclude1CheckBox.Checked)
            {
                ExcludePrefix1 = Exclude1PrefixBox.Text;
                ExcludeSufix1 = Exclude1SufixBox.Text;
            }
            if (Exclude2CheckBox.Checked)
            {
                ExcludePrefix2 = Exclude2PrefixBox.Text;
                ExcludeSufix2 = Exclude2SufixBox.Text;
            }
            if (Exclude3CheckBox.Checked)
            {
                ExcludePrefix3 = Exclude3PrefixBox.Text;
                ExcludeSufix3 = Exclude3SufixBox.Text;
            }

            Form1.form1.Filter_Update();
            Hide();


        }


        private void ExitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Saved = false;
            Hide();

        }
    }
}
