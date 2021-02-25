using System;
using System.Drawing;
using System.Windows.Forms;


namespace BulkRen
{
    public partial class Form1 : Form
    {
        internal static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            form1 = this;   //refering to the current Form
            UndoBtn.Visible = false;
        }

        private readonly Lib L = new Lib();      // Often used 
        private readonly FileFilter Flt = new FileFilter();    // Contain saved variables.


        private Boolean CloseMe = false;    // Flag to prevent double question.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseMe)
            {
                // do nothing
            }
            else
            {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Do you want to Exit now?", "Bulk Rename.",
                       MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
                else
                {
                    CloseMe = true;
                    ExitApp();
                }
            }

        }
      
        private void ShowResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreView();
        }

        public void PreView()
        {
            View V = new View();
            V.Show();

            string[] A;
            A = FileBox.Text.Split('\n');
            V.FillViewBox(A,Original);
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (Width < 400)
                Width = 400; // Adjust for 4 colums. Absolut smallest window size
            if (Height < 300)
                Height = 300; // Adjust for 8 colums
            DupLabel.Location = new Point(Width - 130, 30);
            DuplicateBox.Location = new Point(Width - 73, 27);
            ReferenceBox.Width = Width - 20;
            FileBox.Width = Width - 20; // 18
            FileBox.Height = Height - 122; // 106
            Application.DoEvents();
        }

        private string ReferenceFile = "";  // Working file.
        private bool Live = false;          // Work file selected if true.
        private string[] Undo;              // Undo buffer
        public string[] Original;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // FillBox.Focus()
            Application.DoEvents();
            if (e.KeyCode == Keys.Delete)
            {
                DoDelete();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Insert)
            {
                DoFill();
                e.SuppressKeyPress = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearAll();
            SelectRefFile();
        }




        // ******************************
        // Select work file
        // 
        public void SelectRefFile()
        {
            File_Select F = new File_Select();

            // Debug preset
            // F.SetCurrentDirectory(@"M:\Serier\Black Mirror");

            ReferenceFile = F.Select_From_Current_Dir();
            if (ReferenceFile != "NULL")
            {
                Live = true;
                ReferenceBox.Text = RefFile(ReferenceFile);
                string Sufix = GetSufix(ReferenceBox.Text);

                if (Sufix != "")
                {
                    Flt.IncludeSufix1 = Sufix;
                    Flt.Include1SufixBox.Text = Sufix;
                }
                ReadCurrentDirectory();
            }
            else
            {
                Live = false;
                ReferenceBox.Text = "";
            }
        }

        

        public void ReadCurrentDirectory()
        {
            string[] A;
            FileBox.Clear();
            File_Select F = new File_Select();
            string R = "";

            R = F.Read_From_Current_Dir(R);
            A = R.Split('\n');
            System.Array.Sort(A);
            // 

            ApplyFilter(A);

            // For Each Line In A
            // If Line.Length > 2 Then ' only 2 char or less... Suspect Cr, Lf or CrLf line.
            // If PassThrueFilter(Line) Then   ' Include every thrue line

            // FileBox.AppendText(Line & vbCr)

            // End If
            // End If
            // Next

            Original = FileBox.Text.Split('\n');     // Save original files.
        }

        public void ApplyFilter(string[] A)
        {
            foreach (var Line in A)
            {
                if (Line.Length > 2)
                {
                    if (PassThrueFilter(Line))
                        FileBox.AppendText(Line + '\n');
                }
            }
        }

        public bool PassThrueFilter(string Line)
        {
            string Prefix = GetPrefix(Line);
            string Sufix = GetSufix(Line);

            if (!Excludefilter(Prefix, Sufix))
                return false;
            if (!Includefilter(Prefix, Sufix))
                return false;

            return true;
        }

        // ************************************************
        // Return true if succesfully passed thrue filter.
        // 
        public bool Includefilter(string p, string s)
        {
            if (Flt.IncludePrefix1 == "*")
            {
                if (Flt.IncludeSufix1 == "*")
                    return true; // Anything goes

            }

            if (String.Compare(s.ToLower(), Flt.IncludeSufix1.ToLower()) == 0)
            {
                return true;

            }
                return false;
        }


        // ************************************************
        // Return true if succesfully passed thrue filter.
        // 
        // Not complete....
        public bool Excludefilter(string p, string s)
        {
            return true;

        }



        public string GetPrefix(string Line)
        {
            string[] S = Line.Split('.');
            int l = S.Length;
            if (l == 1)
                return Line; // No dot detected.

            l = S[l - 1].Length + 1; // Add 1 to remove the dot
                                     // Dim Pre As String = L.Left(Line, Line.Length - l)
            return L.Left(Line, Line.Length - l);
        }

        public string GetSufix(string Line)
        {
            string[] S = Line.Split('.');
            int l = S.Length;
            if (l == 1)
                return ""; // No dot detected.
            return S[l - 1];
        }


        public string RefFile(string R)
        {
            File_Select F = new File_Select();
            R = F.SelectOnlyFile(R);
            return R;
        }


        public void ClearAll()
        {
            Live = false;
            ReferenceFile = "";
            FileBox.Clear();
            UndoBtn.Visible = false;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            DoDelete();
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            DoFill();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            DoUndo();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
            SelectRefFile();
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameFiles();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void FileFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flt.Show();
            Flt.Filtersetup();
        }

        private void ExitApp() { 

            // Work for WinForm or Console app
            if (System.Windows.Forms.Application.MessageLoop) 
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
            // Console app
                System.Environment.Exit(1);
            }

        }

private void CreateBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File_Select F = new File_Select();
            int P = 0;
            string R = "\r\n";    // First line must be empty or batch file will not work
            string ToFile = "";
            string[] A;
            A = FileBox.Text.Split('\n');
            Prepare_Undo(A);

            FileBox.Clear();
            foreach (var line in Original)
            {
                if (Original[P].Length > 2)
                {
                    R = R + "Ren " + '"' + Original[P] + '"' + " " + '"' + A[P] + '"' + '\r' + '\n';
                    ToFile = ToFile + R;
                    P++;
                }
            }

            FileBox.AppendText(R);

            //string ans;
            DialogResult ans = MessageBox.Show("Press YES to save file in current directory.", "Create batch file.", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                string D = F.GetCurrentDirectoryPath();
                string PathAndFileName = D + @"\BulkRename.bat";
                System.IO.File.WriteAllText(PathAndFileName, R);
            }

            DoUndo();
        }

        public void RenameFiles()
        {

            string[] A;
            A = FileBox.Text.Split('\n');
            string R = "\r" + "\n";  // First line must be empty or first line will not work
            string ToFile = "";

            int P = 0;

            foreach (var line in Original)
            {
                if (Original[P].Length > 2)
                {
                    try
                    {
                        System.IO.File.Move(Original[P], A[P]);
                        R = R + "Ren " + '"' + A[P] + '"' + " " + '"' + Original[P] + '"' + "\r" + "\n";
                        ToFile  += R;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not rename " + Original[P] + " To " + A[P]);
                    }
                    P++;
                }
            }

            // Create UNDO.BAT 
            File_Select F = new File_Select();
            string D = F.GetCurrentDirectoryPath();
            string PathAndFileName = D + @"\Undo.bat";
            System.IO.File.WriteAllText(PathAndFileName, R);
            MessageBox.Show("Files sucessfully renamed.  " + '\n' +  "Use Undo.bat in same directory if something went wrong." );
            //FileBox.Clear();
        }

        public void DoFill()
        {
            string Fill = FillBox.Text;
            if (Fill.Length == 0)
                return;

            int Pos = ReferenceBox.SelectionStart;
            string s = ReferenceBox.SelectedText;


            string[] A;
            A = FileBox.Text.Split('\n');

            Prepare_Undo(A);
            FileBox.Clear();

            string clean = "";

            // Remove selected if any.
            if (s != "")
            {
                foreach (var line in A)
                {
                    clean = Remove(Pos, s, line);
                    if (clean.Length > 1)
                        FileBox.AppendText(clean + '\n');
                }
                ReferenceBox.Text = Remove(Pos, s, ReferenceBox.Text);
            }
            else
            {
                DoUndo();    // Restore FileBox
                Prepare_Undo(A);
            }



            // Insert 
            A = FileBox.Text.Split('\n');
            FileBox.Clear();

            foreach (var line in A)
            {
                clean = InsertThis(Fill, Pos, line);
                if (clean.Length > 1)
                    FileBox.AppendText(clean + '\n');
            }
            ReferenceBox.Text = InsertThis(Fill, Pos, ReferenceBox.Text);

           // DuplicateBox.Text = Count_Duplicate().ToString;
           // RefreshDuplicateBox();
        }

        public string InsertThis(string s, int Pos, string A)
        {
            if (Pos > A.Length)
                return A;

            string Pre = "";
            string Suf = "";
            if (Pos == 0)
                return s + A; // First position. Just merge and leave.
            if (Pos == A.Length)
                return A + s; // Last position. Merge and return.

            try
            {
                Pre = L.Left(A, Pos);
                Suf = L.Right(A, A.Length - Pos);
            }
            catch (Exception )
            {
               // Pre = Pre;
            }


            return Pre + s + Suf;
        }


        public void Prepare_Undo(string[] A)
        {
            Undo = A;
            ReferenceFile = ReferenceBox.Text;
            UndoBtn.Visible = true;
        }

        public void DoUndo()
        {
            if (Undo == null)
                return;

            FileBox.Clear();

            foreach (var line in Undo)
            {
                if (line.Length > 2)
                    FileBox.AppendText(line + '\n');
            }
            ReferenceBox.Text = ReferenceFile;
            UndoBtn.Visible = false;

           // DuplicateBox.Text = Count_Duplicate().ToString;
           // RefreshDuplicateBox();
        }




        // **************************************************
        // 
        // Delete
        // 
        public void DoDelete()
        {
            string s;
            s = ReferenceBox.SelectedText;
            string[] A;
           // string[] subs = s.Split(' ', '\t');
            A =  FileBox.Text.Split('\n'); // , Split('\n', StringSplitOptions.RemoveEmptyEntries);
            Prepare_Undo(A);
            int Ss = ReferenceBox.SelectionStart;
            int Sl = ReferenceBox.SelectionLength;
            int Fs = FileBox.SelectionStart;
            int Fl = FileBox.SelectionLength;


            // *********************************************
            // Do the Delete
            // 
            // 

            // Noting selected? Exit.
            if (string.IsNullOrEmpty(s))
                return;
            FileBox.Clear();
            string clean = "";
            foreach (var line in A)
            {
                clean = Remove(Ss, s, line);
                if (clean.Length > 1)
                {
                    FileBox.AppendText(clean + '\n'); //'\r');
                }
            }

            ReferenceBox.Text = Remove(Ss, s, ReferenceBox.Text);
            //DuplicateBox.Text = Count_Duplicate().ToString();
            //RefreshDuplicateBox();
        }

        public string Remove(int Ss, string s, string Line)
        {
            int p = 0;
            int len = s.Length;

            string ll = Line.ToLower();

            if (CheckForQestionMark(s))
            {
                if (s.Length <= ll.Length)
                {
                    for (var i = 0; i < s.Length; i++) // for (var i = 1; i <= s.Length; i++)
                    {
                        if (L.Mid(s, i, 1) == "?")
                            
                           ll = L.MidReplace("?",ll, Ss + i, 1);
                    }
                }
            }
            p = ll.IndexOf(s.ToLower());

            if (p < 0)
                return Line;
            int Left_Size = p;
            int RightSize = p + s.Length;

            if (Left_Size > 0)
                s = L.Left(Line, Left_Size);
            else
                s = "";

            if (RightSize > 0)
                s = s + L.Right(Line, Line.Length - RightSize);

            return s;
        }

        public bool CheckForQestionMark(string s)
        {
            if (s.IndexOf("?") < 0)
                return false;
            return true;
        }

        public void Filter_Update()
        {
            if (Live)
            {
                string[] A;
                A = FileBox.Text.Split('\n');

                Prepare_Undo(A);
                FileBox.Clear();

                ApplyFilter(A);
            }
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //}
    }
}
