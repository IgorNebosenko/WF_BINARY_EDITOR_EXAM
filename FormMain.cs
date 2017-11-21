using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BINARY_EDITOR_EXAM
{
    /// <summary>
    /// Enum of encoding
    /// </summary>
    public enum eEncoding : byte
    {
        /// <summary>
        /// ASCII
        /// </summary>
        ASCII,
        /// <summary>
        /// Unicode
        /// </summary>
        Unicode,
        /// <summary>
        /// Octal
        /// </summary>
        Octal,
        /// <summary>
        /// Decimal
        /// </summary>
        Decimal
    }

    /// <summary>
    /// Main form
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// First file
        /// </summary>
        public static FormFile fFirst = null;

        /// <summary>
        /// Encoding first file
        /// </summary>
        eEncoding eFirstFile = eEncoding.ASCII;

        /// <summary>
        /// Second file
        /// </summary>
        public static FormFile fSecond = null;

        /// <summary>
        /// Encoding of second file
        /// </summary>
        eEncoding eSecondFile = eEncoding.ASCII;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event of closing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormMain.fFirst != null)
                FormMain.fFirst.Close();
            if (FormMain.fSecond != null)
                FormMain.fSecond.Close();
        }

        /// <summary>
        /// If press open first file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMFirstFileOpen_Click(object sender, EventArgs e)
        {
            if (FormMain.fFirst != null)
                FormMain.fFirst.Close();

            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FormMain.fFirst = new FormFile(ofd.FileName, this.eFirstFile);
                FormMain.fFirst.MdiParent = this;
                FormMain.fFirst.StartPosition = FormStartPosition.Manual;
                FormMain.fFirst.Show();
            }
        }

        /// <summary>
        /// If press save first file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMFirstFileSave_Click(object sender, EventArgs e)
        {
            if(FormMain.fFirst != null)
                FormMain.fFirst.Save(FormMain.fFirst.sPath);
        }

        /// <summary>
        /// If press save as for first file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMFirstFileSaveAs_Click(object sender, EventArgs e)
        {
            if (FormMain.fFirst != null)
                FormMain.fFirst.SaveAs();
        }

        /// <summary>
        /// Region with edit encoding
        /// </summary>
        #region Edit Encoding

        private void ReloadFirstForm()
        {
            if (FormMain.fFirst != null)
            {
                string sPath = FormMain.fFirst.sPath;
                FormMain.fFirst.Close();
                FormMain.fFirst = new FormFile(sPath, this.eFirstFile);
                FormMain.fFirst.MdiParent = this;
                FormMain.fFirst.StartPosition = FormStartPosition.Manual;
                FormMain.fFirst.Show();
            }
        }

        private void TSMFirstFileASCII_Click(object sender, EventArgs e)
        {
            this.eFirstFile = eEncoding.ASCII;
            if (FormMain.fFirst != null)
                this.ReloadFirstForm();
        }

        private void TSMFirstFileUnicode_Click(object sender, EventArgs e)
        {
            this.eFirstFile = eEncoding.Unicode;
            if (FormMain.fFirst != null)
                this.ReloadFirstForm();
        }

        private void TSMFirstFileOctal_Click(object sender, EventArgs e)
        {
            this.eFirstFile = eEncoding.Octal;
            if (FormMain.fFirst != null)
                this.ReloadFirstForm();
        }

        private void TSMFirstFileDecimal_Click(object sender, EventArgs e)
        {
            this.eFirstFile = eEncoding.Decimal;
            if (FormMain.fFirst != null)
                this.ReloadFirstForm();
        }


        #endregion

        /// <summary>
        /// If opened second file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMSecondFileOpen_Click(object sender, EventArgs e)
        {
            if (FormMain.fSecond != null)
                FormMain.fSecond.Close();

            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FormMain.fSecond = new FormFile(ofd.FileName, this.eSecondFile);
                FormMain.fSecond.MdiParent = this;
                FormMain.fSecond.StartPosition = FormStartPosition.Manual;
                FormMain.fSecond.Show();
            }
        }

        /// <summary>
        /// Save second file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMSecondFileSave_Click(object sender, EventArgs e)
        {
            if (FormMain.fSecond != null)
                FormMain.fSecond.Save(FormMain.fSecond.sPath);
        }

        /// <summary>
        /// Save as another file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMSecondFileSaveAs_Click(object sender, EventArgs e)
        {
            if (FormMain.fSecond != null)
                FormMain.fSecond.SaveAs();
        }

        #region Edit encoding second form

        private void TSMFirstFileClose_Click(object sender, EventArgs e)
        {
            FormMain.fFirst.Close();
            FormMain.fSecond = null;
        }

        private void ReloadSecondForm()
        {
            if (FormMain.fSecond != null)
            {
                string sPath = FormMain.fSecond.sPath;
                FormMain.fSecond.Close();
                FormMain.fSecond = new FormFile(sPath, this.eSecondFile);
                FormMain.fSecond.MdiParent = this;
                FormMain.fSecond.StartPosition = FormStartPosition.Manual;
                FormMain.fSecond.Show();
            }
        }

        private void TSMSecondFileASCII_Click(object sender, EventArgs e)
        {
            this.eSecondFile = eEncoding.ASCII;
            if (FormMain.fSecond != null)
                this.ReloadSecondForm();
        }

        private void TSMSecondFileUnicode_Click(object sender, EventArgs e)
        {
            this.eSecondFile = eEncoding.Unicode;
            if (FormMain.fSecond != null)
                this.ReloadSecondForm();
        }

        private void TSMSecondFileOctal_Click(object sender, EventArgs e)
        {
            this.eSecondFile = eEncoding.Octal;
            if (FormMain.fSecond != null)
                this.ReloadSecondForm();
        }

        private void TSMSecondFileDecimal_Click(object sender, EventArgs e)
        {
            this.eSecondFile = eEncoding.Decimal;
            if (FormMain.fSecond != null)
                this.ReloadSecondForm();
        }


        #endregion

        /// <summary>
        /// Close second file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMSecondFileClose_Click(object sender, EventArgs e)
        {
            FormMain.fSecond.Close();
            FormMain.fSecond = null;
        }

        /// <summary>
        /// Show About block
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMAbout_Click(object sender, EventArgs e)
        {
            var ab = new AboutBox();
            ab.ShowDialog();
        }

        /// <summary>
        /// Close main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
