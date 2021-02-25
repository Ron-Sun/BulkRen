using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Security;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.CompilerServices;
//using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Forms;


namespace BulkRen
{
    public class File_Select
    {
        public string Select_CSV_File(string path)
        {
            string F = Convert.ToString(Select_File(path, "CSV files (*.csv)|*.csv"));
            return F;
        }

        public string Select_TXT_File(string path)
        {
            string F = Select_File(path, "Text files (*.txt)|*.txt");
            return F;
        }

        public string Select_From_Current_Dir() // From current dir.
        {
            string F = Select_File(Environment.CurrentDirectory, "Files (*.*)|*.*");
            return F;
        }

        public string Select_any_File(string path)
        {
            if (path == "")
                path = Environment.CurrentDirectory;// use Current dir.

            // Dim F As String = Select_File(path, "Files (*.*)|*.*")
            return Select_File(path, "Files (*.*)|*.*");
        }

        public string Select_File(string path, string type)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.InitialDirectory = path;         // Ex.  "C:\Data\"
            OFD.Filter = type;                   // Ex.  "Text files (*.txt)|*.txt"
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;

            string F, D;

            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                F = OFD.FileName;
                D = SelectOnlyPath(F);

                try
                {
                    Environment.CurrentDirectory = (D);          // Change to path where file was loaded.
                }
                catch (Exception )
                {

                }
            }
            else
                F = "NULL";// NULL mark that no file was selected.

            return F;
        }

        private Lib L = new Lib();

        public string SelectOnlyPath(string F)
        {
            int C = F.Length;
            int i;
            for (i = C - 1; i >= 1; i += -1)
            {
                if (L.Mid(F, i, 1) == @"\")
                    break;
            }

            if (i < 3)
                return Environment.CurrentDirectory; // To few characters.

            return L.Left(F, i);   // Return path only
        }

        public string SelectOnlyFile(string F)
        {
            int C = F.Length;
            int i;
            for (i = C - 1; i >= 0; i += -1)
            {
                if (L.Mid(F, i, 1) == @"\")
                    break;
            }

            if (i < 0)
                return "!!! Error File missing !!!"; // To few characters.

            return L.Right(F, C - (i+1));   // Return path only
        }

        // *******************************************************
        // 
        // Read from current directory         Directory reader.
        // 
        public string Read_From_Current_Dir(string Str) // From current dir.
        {
            return ReadAllFilesInfo(Str, Environment.CurrentDirectory);
        }

        public void SetCurrentDirectory(string Path)
        {
            System.IO.Directory.SetCurrentDirectory(Path);
        }

        public string GetCurrentDirectoryPath()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }


        // *******************************************************
        // 
        // Read files and filesize             Directory reader.
        // 
        // 
        public string ReadAllFilesInfo(string Reply, string path)
        {

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path); // "C:\temp")
            System.IO.FileInfo[] aryFi = di.GetFiles("*.*");

            foreach (var fi in aryFi)
                Reply = Reply + fi.Name + "\n"; //vbLf;

            return Reply;
        }


        //public void Helpme()
        //{

        //        string str = "ABCDEFG";
        //        string newstr = str.Substring(0, 3);

        //        //  vbCr = "\r"
        //        //  vbLf = "\n"
        //        //  vbCrLf = "\r\n"

        //        //  C# (string) OBS. Zerobased
        //        //Left  string.Substring(0, nCount)     From start to index.
        //        //Mid   string.Substring(nIndex)        From index to end.
        //        //Mid   string.Substring(nIndex, nCount)From start to end.
        //        //Right string.Substring(string.Length - nCount, nCount) From end-nr,nr

        //}

        
    }
}
