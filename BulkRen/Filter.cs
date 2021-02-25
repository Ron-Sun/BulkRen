using System;
using System.Windows.Forms;

namespace BulkRen.Properties
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

        private void Form1_Closed(object sender, EventArgs e)
        {
            Saved = false;
           // My.MyProject.Forms.Form1.Show();
        }

        public void Filtersetup()
        {
            Include1PrefixBox.Focus();
        }


        private void SaveCloseToolStripMenuItem_Click(object sender, EventArgs e)
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

            //My.MyProject.Forms.Form1.Filter_Update();
            //My.MyProject.Forms.Form1.Show();
            Hide();
        }


        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Saved = false;
           // My.MyProject.Forms.Form1.Show();
            Hide();

        }

        //private Lib L = new Lib();

        public string RemoveDot(string S)
        {
             Lib L = new Lib();
           
            if (!string.IsNullOrEmpty(S))
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

        ////Zero based...Adapt to
        //public string Left(string s, int x)
        //{
        //    return s.Substring(0, x);
        //}

        //public string Right(string s, int x)
        //{
        //    return s.Substring(s.Length - x, x);
        //}

        //public string Mid(string s, int p, int l)
        //{
        //    return s.Substring(p, l);
        //}
    }
}
