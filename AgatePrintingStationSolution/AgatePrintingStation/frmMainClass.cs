using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace AgatePrintingStation
{
    class frmMainClass
    {
        private string NetworkDirectory;
        private string CompanyListDirectory;
        private string NoteFile;

        public frmMainClass()
        {
            //CheckDirectories();
        }

        #region DirectorySet
        private void CheckDirectories()
        {
            InitializeDirectories();
            CreateDirectory(NetworkDirectory);
            CreateDirectory(CompanyListDirectory);
            InitializeFiles();
        }

        private void InitializeFiles()
        {
            NoteFile = NetworkDirectory + "Notes";
        }

        private void InitializeDirectories()
        {
            NetworkDirectory = @"\\192.168.2.125\program\Agate Monitoring Folder\";
            CompanyListDirectory = NetworkDirectory + @"Company List\";
        }

        private void CreateDirectory(string DirectoryPath)
        {
            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);
        }
        #endregion

        public void RefreshNotes(ref ListBox lstNotes)
        {
            if (File.Exists(NoteFile))
            {
                lstNotes.Items.Clear();
                StreamReader ReadNotes = new StreamReader(NoteFile);
                while (!ReadNotes.EndOfStream)
                {
                    lstNotes.Items.Add(ReadNotes.ReadLine());
                }
                ReadNotes.Close();
            }
        }
        public void AddNote(string NoteString)
        {
            StreamWriter WriteNotes = new StreamWriter(NoteFile, true);
            WriteNotes.WriteLine(NoteString);
            WriteNotes.Close();   
        }
        public void ClearItem(ref ListBox lstNotes, int SelectedIndex)
        {
            lstNotes.Items.RemoveAt(SelectedIndex);
            UpdateTextFile(lstNotes);
        }

        private void UpdateTextFile(ListBox lstNotes)
        {
            StreamWriter WriteNotes = new StreamWriter(NoteFile);
            for (int index = 0; index < lstNotes.Items.Count; ++index)
                WriteNotes.WriteLine(lstNotes.Items[index]);
            WriteNotes.Close();
        }
    }
}
