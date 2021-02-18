using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryScanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenDirectory();
        }

       private void OpenDirectory()
       {
            var dialog = new FolderBrowserDialog();
            var dialogResult = dialog.ShowDialog();
            var path = dialog.SelectedPath;
            if(dialogResult == DialogResult.OK
                && !string.IsNullOrWhiteSpace(path)
                && Directory.Exists(path))
            {
                var directories = Directory.GetDirectories(path);
                var files = Directory.GetFiles(path);

            }
       }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
