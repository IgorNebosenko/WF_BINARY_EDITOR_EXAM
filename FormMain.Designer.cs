namespace WF_BINARY_EDITOR_EXAM
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MSMenu = new System.Windows.Forms.MenuStrip();
            this.TSMFirstFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFirstFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFirstFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFirstFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMFirstFileASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFirstFileUnicode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFirstFileOctal = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFirstFileDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMFirstFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSecondFileASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFileUnicode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFileOctal = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSecondFileDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMSecondFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSMenu
            // 
            this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFirstFile,
            this.TSMSecondFile,
            this.TSMAbout,
            this.TSMExit});
            this.MSMenu.Location = new System.Drawing.Point(0, 0);
            this.MSMenu.Name = "MSMenu";
            this.MSMenu.Size = new System.Drawing.Size(1264, 24);
            this.MSMenu.TabIndex = 1;
            this.MSMenu.Text = "menuStrip1";
            // 
            // TSMFirstFile
            // 
            this.TSMFirstFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFirstFileOpen,
            this.TSMFirstFileSave,
            this.TSMFirstFileSaveAs,
            this.toolStripSeparator1,
            this.TSMFirstFileASCII,
            this.TSMFirstFileUnicode,
            this.TSMFirstFileOctal,
            this.TSMFirstFileDecimal,
            this.toolStripSeparator2,
            this.TSMFirstFileClose});
            this.TSMFirstFile.Name = "TSMFirstFile";
            this.TSMFirstFile.Size = new System.Drawing.Size(60, 20);
            this.TSMFirstFile.Text = "First file";
            // 
            // TSMFirstFileOpen
            // 
            this.TSMFirstFileOpen.Name = "TSMFirstFileOpen";
            this.TSMFirstFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMFirstFileOpen.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileOpen.Text = "Open";
            this.TSMFirstFileOpen.Click += new System.EventHandler(this.TSMFirstFileOpen_Click);
            // 
            // TSMFirstFileSave
            // 
            this.TSMFirstFileSave.Name = "TSMFirstFileSave";
            this.TSMFirstFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMFirstFileSave.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileSave.Text = "Save";
            this.TSMFirstFileSave.Click += new System.EventHandler(this.TSMFirstFileSave_Click);
            // 
            // TSMFirstFileSaveAs
            // 
            this.TSMFirstFileSaveAs.Name = "TSMFirstFileSaveAs";
            this.TSMFirstFileSaveAs.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileSaveAs.Text = "Save as...";
            this.TSMFirstFileSaveAs.Click += new System.EventHandler(this.TSMFirstFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // TSMFirstFileASCII
            // 
            this.TSMFirstFileASCII.Name = "TSMFirstFileASCII";
            this.TSMFirstFileASCII.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileASCII.Text = "Show in ASCII";
            this.TSMFirstFileASCII.Click += new System.EventHandler(this.TSMFirstFileASCII_Click);
            // 
            // TSMFirstFileUnicode
            // 
            this.TSMFirstFileUnicode.Name = "TSMFirstFileUnicode";
            this.TSMFirstFileUnicode.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileUnicode.Text = "Show in Unicode";
            this.TSMFirstFileUnicode.Click += new System.EventHandler(this.TSMFirstFileUnicode_Click);
            // 
            // TSMFirstFileOctal
            // 
            this.TSMFirstFileOctal.Name = "TSMFirstFileOctal";
            this.TSMFirstFileOctal.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileOctal.Text = "Show in Octal";
            this.TSMFirstFileOctal.Click += new System.EventHandler(this.TSMFirstFileOctal_Click);
            // 
            // TSMFirstFileDecimal
            // 
            this.TSMFirstFileDecimal.Name = "TSMFirstFileDecimal";
            this.TSMFirstFileDecimal.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileDecimal.Text = "Show in Decimal";
            this.TSMFirstFileDecimal.Click += new System.EventHandler(this.TSMFirstFileDecimal_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // TSMFirstFileClose
            // 
            this.TSMFirstFileClose.Name = "TSMFirstFileClose";
            this.TSMFirstFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.TSMFirstFileClose.Size = new System.Drawing.Size(163, 22);
            this.TSMFirstFileClose.Text = "Close";
            this.TSMFirstFileClose.Click += new System.EventHandler(this.TSMFirstFileClose_Click);
            // 
            // TSMSecondFile
            // 
            this.TSMSecondFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMSecondFileOpen,
            this.TSMSecondFileSave,
            this.TSMSecondFileSaveAs,
            this.toolStripSeparator3,
            this.TSMSecondFileASCII,
            this.TSMSecondFileUnicode,
            this.TSMSecondFileOctal,
            this.TSMSecondFileDecimal,
            this.toolStripSeparator4,
            this.TSMSecondFileClose});
            this.TSMSecondFile.Name = "TSMSecondFile";
            this.TSMSecondFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.TSMSecondFile.Size = new System.Drawing.Size(77, 20);
            this.TSMSecondFile.Text = "Second file";
            // 
            // TSMSecondFileOpen
            // 
            this.TSMSecondFileOpen.Name = "TSMSecondFileOpen";
            this.TSMSecondFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.TSMSecondFileOpen.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileOpen.Text = "Open";
            this.TSMSecondFileOpen.Click += new System.EventHandler(this.TSMSecondFileOpen_Click);
            // 
            // TSMSecondFileSave
            // 
            this.TSMSecondFileSave.Name = "TSMSecondFileSave";
            this.TSMSecondFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.TSMSecondFileSave.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileSave.Text = "Save";
            this.TSMSecondFileSave.Click += new System.EventHandler(this.TSMSecondFileSave_Click);
            // 
            // TSMSecondFileSaveAs
            // 
            this.TSMSecondFileSaveAs.Name = "TSMSecondFileSaveAs";
            this.TSMSecondFileSaveAs.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileSaveAs.Text = "Save as...";
            this.TSMSecondFileSaveAs.Click += new System.EventHandler(this.TSMSecondFileSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // TSMSecondFileASCII
            // 
            this.TSMSecondFileASCII.Name = "TSMSecondFileASCII";
            this.TSMSecondFileASCII.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileASCII.Text = "Show in ASCII";
            this.TSMSecondFileASCII.Click += new System.EventHandler(this.TSMSecondFileASCII_Click);
            // 
            // TSMSecondFileUnicode
            // 
            this.TSMSecondFileUnicode.Name = "TSMSecondFileUnicode";
            this.TSMSecondFileUnicode.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileUnicode.Text = "Show in Unicode";
            this.TSMSecondFileUnicode.Click += new System.EventHandler(this.TSMSecondFileUnicode_Click);
            // 
            // TSMSecondFileOctal
            // 
            this.TSMSecondFileOctal.Name = "TSMSecondFileOctal";
            this.TSMSecondFileOctal.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileOctal.Text = "Show in Octal";
            this.TSMSecondFileOctal.Click += new System.EventHandler(this.TSMSecondFileOctal_Click);
            // 
            // TSMSecondFileDecimal
            // 
            this.TSMSecondFileDecimal.Name = "TSMSecondFileDecimal";
            this.TSMSecondFileDecimal.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileDecimal.Text = "Show in Decimal";
            this.TSMSecondFileDecimal.Click += new System.EventHandler(this.TSMSecondFileDecimal_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(160, 6);
            // 
            // TSMSecondFileClose
            // 
            this.TSMSecondFileClose.Name = "TSMSecondFileClose";
            this.TSMSecondFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.TSMSecondFileClose.Size = new System.Drawing.Size(163, 22);
            this.TSMSecondFileClose.Text = "Close";
            this.TSMSecondFileClose.Click += new System.EventHandler(this.TSMSecondFileClose_Click);
            // 
            // TSMAbout
            // 
            this.TSMAbout.Name = "TSMAbout";
            this.TSMAbout.Size = new System.Drawing.Size(52, 20);
            this.TSMAbout.Text = "About";
            this.TSMAbout.Click += new System.EventHandler(this.TSMAbout_Click);
            // 
            // TSMExit
            // 
            this.TSMExit.Name = "TSMExit";
            this.TSMExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMExit.Size = new System.Drawing.Size(37, 20);
            this.TSMExit.Text = "Exit";
            this.TSMExit.Click += new System.EventHandler(this.TSMExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MSMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSMenu;
            this.Name = "FormMain";
            this.Text = "Binary Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFile;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileSave;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileASCII;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileUnicode;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileOctal;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileDecimal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMFirstFileClose;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFile;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileSave;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileASCII;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileUnicode;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileOctal;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileDecimal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMSecondFileClose;
        private System.Windows.Forms.ToolStripMenuItem TSMAbout;
        private System.Windows.Forms.ToolStripMenuItem TSMExit;
    }
}

