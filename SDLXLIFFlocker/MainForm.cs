using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SDLXLIFFlocker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }

        private void selectFolder(object sender, EventArgs e)
        {
            var selectFolderDialog = new FolderBrowserDialog();
            selectFolderDialog.ShowNewFolderButton = false;
            selectFolderDialog.Description = "Select a folder with Trados sdlxliff files";
            if (selectFolderDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxFolderPath.Text = selectFolderDialog.SelectedPath;                 
            }
        }

        private async void lock100Matches(object sender, EventArgs e)
        {            
            if (Directory.Exists(textBoxFolderPath.Text))
            {
                string[] sdlxliffFiles = Directory.GetFiles(textBoxFolderPath.Text, "*.sdlxliff", SearchOption.AllDirectories);
                await Task.Run(() =>
                    {
                        foreach (string file in sdlxliffFiles)
                        {
                            textBoxLog.Invoke((Action)delegate { textBoxLog.AppendText(file); });
                            var sdlxliff = new SDLXLIFF(file);
                            int[] results = sdlxliff.Lock100Matches();
                            sdlxliff.Write();
                            textBoxLog.Invoke((Action)delegate { textBoxLog.AppendText(String.Format(" - Locked {0} of {1}\r\n", results[0].ToString(), results[1].ToString())); });                        
                        }
                    });                    
                 textBoxLog.AppendText(String.Format("Done! Files processed: {0}\r\n", sdlxliffFiles.Length));
            }
            else
            {
                MessageBox.Show(this, String.Format("Invalid path: {0}", textBoxFolderPath.Text), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }        

        private async void unlockSegments(object sender, EventArgs e)
        {            
        }

        private void clearLog(object sender, EventArgs e)
        {
            textBoxLog.Clear();
        } 
    }
}
