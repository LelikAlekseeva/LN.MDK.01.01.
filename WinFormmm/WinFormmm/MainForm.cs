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

namespace WinFormmm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FileNamesListBox.Items.Add("Школа");
            FileNamesListBox.Items.Add("кАлледж");
            FileNamesListBox.Items.Add("Детский сад");
        }

        private void DelteButton_Click(object sender, EventArgs e)
        {

        }

        private void FileNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///MessageBox.Show(FileNamesListBox.SelectedIndex.ToString());
            ///MessageBox.Show(FileNamesListBox.SelectedItem.ToString());
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var filePath = string.Empty;

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files|image files (*.PNG)*.PNG|image files (*.BMP)*.BMP|";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    FileNamesListBox.Items.Add(filePath);
                }
            }
        }
    }
}
