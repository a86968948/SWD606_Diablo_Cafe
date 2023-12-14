using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;

namespace SWD606_Diablo_Cafe
{
    public partial class UpLoad : Form
    {
        public UpLoad()
        {
            InitializeComponent();
        }
        string TargetLocation;
        string SourceLocation;

        private void LocationPathBt_Click(object sender, EventArgs e)
        {
           TargetLocation =  FolderLocation();
        }

        private void Location2Bt_Click(object sender, EventArgs e)
        {
           SourceLocation =  FileLocation();
        }

        private void Uploadbt_Click(object sender, EventArgs e)
        {
            string FinalTL = Path.Combine(TargetLocation, Path.GetFileName(SourceLocation));
            File.Copy(SourceLocation, FinalTL, true);
            Process.Start("explorer.exe", TargetLocation);
            SourceLocation = null;
            Pathtxt2.Text = " ";
        }
        public string FolderLocation()
        {
            string FolderPath = null;
            FolderBrowserDialog FbDialog = new FolderBrowserDialog();
            DialogResult result = FbDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FolderPath = FbDialog.SelectedPath;
                Pathtxt1.Text =FolderPath;
                return FolderPath;
                
            }
            else
            {
                MessageBox.Show("That's not a folder, pleace try again.");
                return null;
            }
        }
        public string FileLocation()
        { 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "(*.*)|*.*";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedfilepath = ofd.FileName;
                Pathtxt2.Text =selectedfilepath;
                return selectedfilepath;
            }
            else
            {
                MessageBox.Show("That's not a file, pleace try again.");
                return null;
            }
        
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            new FunctionP().Show();
            this.Hide();    
        }

        private void UpLoad_Load(object sender, EventArgs e)
        {

        }
    }
}
