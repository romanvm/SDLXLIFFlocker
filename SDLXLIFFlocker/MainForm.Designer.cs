namespace SDLXLIFFlocker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.buttonLockSegments = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonUnlockSegments = new System.Windows.Forms.Button();
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.checkBoxIgnoreLocked = new System.Windows.Forms.CheckBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(8, 8);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(88, 23);
            this.buttonSelectFolder.TabIndex = 0;
            this.buttonSelectFolder.Text = "Select folder...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.selectFolder);
            // 
            // buttonLockSegments
            // 
            this.buttonLockSegments.Location = new System.Drawing.Point(8, 40);
            this.buttonLockSegments.Name = "buttonLockSegments";
            this.buttonLockSegments.Size = new System.Drawing.Size(88, 23);
            this.buttonLockSegments.TabIndex = 1;
            this.buttonLockSegments.Text = "Lock 100%";
            this.buttonLockSegments.UseVisualStyleBackColor = true;
            this.buttonLockSegments.Click += new System.EventHandler(this.lock100Matches);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.AllowDrop = true;
            this.textBoxFolderPath.Location = new System.Drawing.Point(104, 8);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(544, 20);
            this.textBoxFolderPath.TabIndex = 2;
            // 
            // buttonUnlockSegments
            // 
            this.buttonUnlockSegments.Location = new System.Drawing.Point(104, 40);
            this.buttonUnlockSegments.Name = "buttonUnlockSegments";
            this.buttonUnlockSegments.Size = new System.Drawing.Size(88, 23);
            this.buttonUnlockSegments.TabIndex = 3;
            this.buttonUnlockSegments.Text = "Unlock";
            this.buttonUnlockSegments.UseVisualStyleBackColor = true;
            this.buttonUnlockSegments.Click += new System.EventHandler(this.unlockSegments);
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.Location = new System.Drawing.Point(200, 40);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(112, 23);
            this.buttonCheckStatus.TabIndex = 4;
            this.buttonCheckStatus.Text = "Check untranslated";
            this.buttonCheckStatus.UseVisualStyleBackColor = true;
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Enabled = false;
            this.buttonSaveLog.Location = new System.Drawing.Point(560, 40);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(88, 23);
            this.buttonSaveLog.TabIndex = 5;
            this.buttonSaveLog.Text = "Save log...";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreLocked
            // 
            this.checkBoxIgnoreLocked.AutoSize = true;
            this.checkBoxIgnoreLocked.Location = new System.Drawing.Point(320, 48);
            this.checkBoxIgnoreLocked.Name = "checkBoxIgnoreLocked";
            this.checkBoxIgnoreLocked.Size = new System.Drawing.Size(139, 17);
            this.checkBoxIgnoreLocked.TabIndex = 7;
            this.checkBoxIgnoreLocked.Text = "Ignore locked segments";
            this.checkBoxIgnoreLocked.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(8, 72);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(640, 368);
            this.textBoxLog.TabIndex = 9;
            this.textBoxLog.WordWrap = false;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(464, 40);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(88, 23);
            this.buttonClearLog.TabIndex = 10;
            this.buttonClearLog.Text = "Clear log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.clearLog);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 449);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.checkBoxIgnoreLocked);
            this.Controls.Add(this.buttonSaveLog);
            this.Controls.Add(this.buttonCheckStatus);
            this.Controls.Add(this.buttonUnlockSegments);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.buttonLockSegments);
            this.Controls.Add(this.buttonSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDLXLIFF Locker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button buttonLockSegments;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonUnlockSegments;
        private System.Windows.Forms.Button buttonCheckStatus;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.CheckBox checkBoxIgnoreLocked;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonClearLog;
    }
}

