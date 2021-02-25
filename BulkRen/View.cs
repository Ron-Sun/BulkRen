using System;
using System.Windows.Forms;

namespace BulkRen
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            //public event EventHandler Resize;
    }




        //private void Vie(object sender, EventArgs e)
        //{ }


        private void View_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
         
            if (Width < 400)
                Width = 400; // Adjust for 4 colums. Absolut smallest window size

            if (Height < 300)
                Height = 300; // Adjust for 8 colums

            ViewBox.Width = Width - 5; // 18
            ViewBox.Height = Height - 5; // 106
            Application.DoEvents();
        }

        public void FillViewBox(string[] A, string[] Original)
        {
            int P = 0;
            ViewBox.Clear();
            foreach (var line in Original)
            {
                if (Original[P].Length > 2)
                {
                    // View.ViewBox.AppendText("Ren " & Original(P) & "     " & A(P) & vbLf)
                    ViewBox.AppendText("Rename " + '"'  + Original[P] + '"' + "         " + '"' + A[P] + '"' + '\n');
                    P++;
                }
            }


        }



    }
}
