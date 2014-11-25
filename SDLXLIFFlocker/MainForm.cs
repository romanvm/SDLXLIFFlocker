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
            comboBoxSelectStatus.SelectedIndex = 2;
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

        private async void lockUnlockChangeStatus(object sender, EventArgs e)
        {

            if (Directory.Exists(textBoxFolderPath.Text))
            {
                string text;
                if (((Button)sender).Text == "Lock 100%")
                {
                    text  = "Locked";
                }
                else if (((Button)sender).Text == "Unlock")
                {
                    text = "Unlocked";
                }
                else
                {
                    text = comboBoxSelectStatus.Text;
                }
                enableControls(false);
                textBoxLog.Cursor = Cursors.WaitCursor;                
                Application.DoEvents();
                int filesProcessed = await lockUnlockChangeStatusAsync(text, checkBoxIgnoreLocked.Checked);               
                textBoxLog.Cursor = Cursors.Default;                
                enableControls(true);
                textBoxLog.AppendText(String.Format("Finised. Files processed: {0}\r\n", filesProcessed.ToString()));
            }
            else
            {
                MessageBox.Show(this, String.Format("Invalid path: {0}", textBoxFolderPath.Text), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        async Task<int> lockUnlockChangeStatusAsync(string text, bool ignoreLocked)
        {
            return await Task.Run(() =>
            {
                string[] sdlxliffFiles = Directory.GetFiles(textBoxFolderPath.Text, "*.sdlxliff", SearchOption.AllDirectories);                
                foreach (string file in sdlxliffFiles)
                {
                    textBoxLog.Invoke((Action)delegate
                    {
                        textBoxLog.AppendText(file);
                    });                    
                    var sdlxliff = new SDLXLIFF(file);
                    string logMessage;
                    if (text == "Locked" || text == "Unlocked")
                    {
                        int[] results;
                        if (text == "Locked")
                        {
                            results = sdlxliff.Lock100Matches();
                        }
                        else
                        {
                            results = sdlxliff.Unlock();
                        }
                        logMessage = String.Format(" -- {0} {1} of {2}\r\n", text, results[0].ToString(), results[1].ToString());
                    }
                    else
                    {
                        sdlxliff.ChangeSegmentStatus(text, ignoreLocked);
                        logMessage = " -- done \r\n";
                    }
                    sdlxliff.Write();
                    textBoxLog.Invoke((Action)delegate
                    {
                        textBoxLog.AppendText(logMessage);
                    });                    
                }
                return sdlxliffFiles.Length;
            });
        }

        private async void checkSegments(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxFolderPath.Text))
            {
                string text;
                if (((Button)sender).Text == "Check untranslated")
                {
                    text = "untranslated";
                }
                else
                {
                    text = "unreviewed";
                }
                enableControls(false);
                textBoxLog.Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                int[] results = await checkSegmentsAsync(checkBoxIgnoreLocked.Checked, text);
                textBoxLog.Cursor = Cursors.Default;
                enableControls(true);
                textBoxLog.AppendText(String.Format("Finished. Files with {0} segments: {1} of {2}\r\n", text, results[0].ToString(), results[1].ToString()));
            }
            else
            {
                MessageBox.Show(this, String.Format("Invalid path: {0}", textBoxFolderPath.Text), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async Task<int[]> checkSegmentsAsync(bool ignoreLocked, string text)
        {
            return await Task.Run(() =>
            {
                string[] sdlxliffFiles = Directory.GetFiles(textBoxFolderPath.Text, "*.sdlxliff", SearchOption.AllDirectories);
                int filesWithErrors = 0;
                foreach (string file in sdlxliffFiles)
                {
                    textBoxLog.Invoke((Action)delegate
                    {
                        textBoxLog.AppendText(file);
                    });
                    var sdlxliff = new SDLXLIFF(file);
                    List<int> errorSegments;
                    if (text == "untranslated")
                    {
                        errorSegments = sdlxliff.CheckUntranslated(ignoreLocked);
                    }
                    else
                    {
                        errorSegments = sdlxliff.CheckUnreviewed(ignoreLocked);
                    }
                    if (errorSegments.Count > 0)
                    {
                        filesWithErrors++;
                        textBoxLog.Invoke((Action)delegate
                        {
                            textBoxLog.AppendText(String.Format(" -- Segments {0}: ", text));
                        });
                        foreach (int segment in errorSegments)
                        {
                            textBoxLog.Invoke((Action)delegate
                            {
                                textBoxLog.AppendText(segment.ToString() + "; ");
                            });
                        }                        
                    }
                    else
                    {
                        textBoxLog.Invoke((Action)delegate
                        {
                            textBoxLog.AppendText(" -- OK");
                        });
                    }
                    textBoxLog.Invoke((Action)delegate
                    {
                        textBoxLog.AppendText("\r\n");
                    });
                }
                return new int[] { filesWithErrors, sdlxliffFiles.Length };
            });
        }        

        private async void saveLog(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Log";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.FileName = "sdlxlifLog";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using (var fileStream = File.Create(saveFileDialog.FileName))
                {
                    var writer = new StreamWriter(fileStream);
                    await writer.WriteAsync(textBoxLog.Text);
                    writer.Close();
                }
                textBoxLog.AppendText(String.Format("Log saved to {0}\r\n", saveFileDialog.FileName));
            }
        }

        private void clearLog(object sender, EventArgs e)
        {
            textBoxLog.Clear();
        }

        private void dragHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }                
            else
            {
                e.Effect = DragDropEffects.None;
            }                
        }

        private void dropHandler(object sender, DragEventArgs e)
        {
            string[] pathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBoxFolderPath.Text = pathArray[0];         
        }

        void enableControls(bool enabled = true)
        {
            buttonLockSegments.Enabled = enabled;
            buttonUnlockSegments.Enabled = enabled;
            buttonCheckUntranslated.Enabled = enabled;
            buttonCheckUnreviewed.Enabled = enabled;
            buttonSaveLog.Enabled = enabled;
            buttonClearLog.Enabled = enabled;
            buttonSelectFolder.Enabled = enabled;
            checkBoxIgnoreLocked.Enabled = enabled;
        }       
    }
}
