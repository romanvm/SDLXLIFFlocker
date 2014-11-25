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
            this.components = new System.ComponentModel.Container();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.buttonLockSegments = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonUnlockSegments = new System.Windows.Forms.Button();
            this.buttonCheckUntranslated = new System.Windows.Forms.Button();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.checkBoxIgnoreLocked = new System.Windows.Forms.CheckBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.buttonCheckUnreviewed = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectStatus = new System.Windows.Forms.ComboBox();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(8, 8);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(96, 23);
            this.buttonSelectFolder.TabIndex = 0;
            this.buttonSelectFolder.Text = "Select folder...";
            this.toolTip.SetToolTip(this.buttonSelectFolder, "Select a folder with sdlxliff files.");
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.selectFolder);
            // 
            // buttonLockSegments
            // 
            this.buttonLockSegments.Location = new System.Drawing.Point(8, 48);
            this.buttonLockSegments.Name = "buttonLockSegments";
            this.buttonLockSegments.Size = new System.Drawing.Size(120, 23);
            this.buttonLockSegments.TabIndex = 1;
            this.buttonLockSegments.Text = "Lock 100%";
            this.toolTip.SetToolTip(this.buttonLockSegments, "Lock all pre-translated 100% matches.");
            this.buttonLockSegments.UseVisualStyleBackColor = true;
            this.buttonLockSegments.Click += new System.EventHandler(this.lockUnlockChangeStatus);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.AllowDrop = true;
            this.textBoxFolderPath.Location = new System.Drawing.Point(112, 8);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(464, 20);
            this.textBoxFolderPath.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxFolderPath, "Drag and drop a folder with sdlxlif files here.");
            this.textBoxFolderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropHandler);
            this.textBoxFolderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragHandler);
            // 
            // buttonUnlockSegments
            // 
            this.buttonUnlockSegments.Location = new System.Drawing.Point(8, 80);
            this.buttonUnlockSegments.Name = "buttonUnlockSegments";
            this.buttonUnlockSegments.Size = new System.Drawing.Size(120, 23);
            this.buttonUnlockSegments.TabIndex = 3;
            this.buttonUnlockSegments.Text = "Unlock";
            this.toolTip.SetToolTip(this.buttonUnlockSegments, "Unlock all locked segments.");
            this.buttonUnlockSegments.UseVisualStyleBackColor = true;
            this.buttonUnlockSegments.Click += new System.EventHandler(this.lockUnlockChangeStatus);
            // 
            // buttonCheckUntranslated
            // 
            this.buttonCheckUntranslated.Location = new System.Drawing.Point(8, 48);
            this.buttonCheckUntranslated.Name = "buttonCheckUntranslated";
            this.buttonCheckUntranslated.Size = new System.Drawing.Size(120, 23);
            this.buttonCheckUntranslated.TabIndex = 4;
            this.buttonCheckUntranslated.Text = "Check untranslated";
            this.toolTip.SetToolTip(this.buttonCheckUntranslated, "Check for segments with \"Not translated\" and \"Draft\" status.");
            this.buttonCheckUntranslated.UseVisualStyleBackColor = true;
            this.buttonCheckUntranslated.Click += new System.EventHandler(this.checkSegments);
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Location = new System.Drawing.Point(8, 80);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(120, 23);
            this.buttonSaveLog.TabIndex = 5;
            this.buttonSaveLog.Text = "Save log...";
            this.toolTip.SetToolTip(this.buttonSaveLog, "Save the log to a text file.");
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            this.buttonSaveLog.Click += new System.EventHandler(this.saveLog);
            // 
            // checkBoxIgnoreLocked
            // 
            this.checkBoxIgnoreLocked.AutoSize = true;
            this.checkBoxIgnoreLocked.Location = new System.Drawing.Point(8, 24);
            this.checkBoxIgnoreLocked.Name = "checkBoxIgnoreLocked";
            this.checkBoxIgnoreLocked.Size = new System.Drawing.Size(100, 19);
            this.checkBoxIgnoreLocked.TabIndex = 7;
            this.checkBoxIgnoreLocked.Text = "Ignore locked";
            this.toolTip.SetToolTip(this.checkBoxIgnoreLocked, "Ignore locked segments during checks.");
            this.checkBoxIgnoreLocked.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(8, 160);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(568, 392);
            this.textBoxLog.TabIndex = 9;
            this.textBoxLog.WordWrap = false;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(8, 48);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(120, 23);
            this.buttonClearLog.TabIndex = 10;
            this.buttonClearLog.Text = "Clear log";
            this.toolTip.SetToolTip(this.buttonClearLog, "Clear text in the log box.");
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.clearLog);
            // 
            // buttonCheckUnreviewed
            // 
            this.buttonCheckUnreviewed.Location = new System.Drawing.Point(8, 80);
            this.buttonCheckUnreviewed.Name = "buttonCheckUnreviewed";
            this.buttonCheckUnreviewed.Size = new System.Drawing.Size(120, 23);
            this.buttonCheckUnreviewed.TabIndex = 11;
            this.buttonCheckUnreviewed.Text = "Check unreviewed";
            this.toolTip.SetToolTip(this.buttonCheckUnreviewed, "Check for segments without \"Translation Approved\" status.");
            this.buttonCheckUnreviewed.UseVisualStyleBackColor = true;
            this.buttonCheckUnreviewed.Click += new System.EventHandler(this.checkSegments);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLockSegments);
            this.groupBox1.Controls.Add(this.buttonUnlockSegments);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lock / unlock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCheckUntranslated);
            this.groupBox2.Controls.Add(this.buttonCheckUnreviewed);
            this.groupBox2.Controls.Add(this.checkBoxIgnoreLocked);
            this.groupBox2.Location = new System.Drawing.Point(152, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 112);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonClearLog);
            this.groupBox3.Controls.Add(this.buttonSaveLog);
            this.groupBox3.Location = new System.Drawing.Point(440, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 112);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // comboBoxSelectStatus
            // 
            this.comboBoxSelectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectStatus.FormattingEnabled = true;
            this.comboBoxSelectStatus.Items.AddRange(new object[] {
            "Untranslated",
            "Draft",
            "Translated",
            "ApprovedTranslation",
            "ApprovedSignOff"});
            this.comboBoxSelectStatus.Location = new System.Drawing.Point(8, 48);
            this.comboBoxSelectStatus.Name = "comboBoxSelectStatus";
            this.comboBoxSelectStatus.Size = new System.Drawing.Size(120, 21);
            this.comboBoxSelectStatus.TabIndex = 15;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(8, 80);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(120, 23);
            this.buttonChangeStatus.TabIndex = 16;
            this.buttonChangeStatus.Text = "Change status";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.lockUnlockChangeStatus);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxSelectStatus);
            this.groupBox4.Controls.Add(this.buttonChangeStatus);
            this.groupBox4.Location = new System.Drawing.Point(296, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 112);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Change status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "New status:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 560);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.buttonSelectFolder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDLXLIFF Locker  v. 0.9.2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button buttonLockSegments;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonUnlockSegments;
        private System.Windows.Forms.Button buttonCheckUntranslated;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.CheckBox checkBoxIgnoreLocked;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonCheckUnreviewed;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxSelectStatus;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}

