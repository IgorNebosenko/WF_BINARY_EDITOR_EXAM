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

namespace WF_BINARY_EDITOR_EXAM
{
    /// <summary>
    /// Form of showing file
    /// </summary>
    public partial class FormFile : Form
    {
        /// <summary>
        /// String with path
        /// </summary>
        public string sPath = null;

        /// <summary>
        /// String with encoding
        /// </summary>
        eEncoding eE = eEncoding.ASCII;

        /// <summary>
        /// One step
        /// </summary>
        const int iStep = 16;

        /// <summary>
        /// Size of one element of ListView
        /// </summary>
        const int iSizeList = 33;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormFile(string sPath, eEncoding eE)
        {
            InitializeComponent();

            try
            {
                this.sPath = sPath;
                this.eE = eE;

                this.Text = string.Concat(this.sPath, " + ", this.eE.ToString());

                byte[] buf = File.ReadAllBytes(this.sPath);
                for (var i = 0; i < buf.Length; i += FormFile.iStep)
                {
                    string[] sBuf = new string[FormFile.iSizeList];
                    sBuf[0] = i.ToString("X").PadLeft(16, '0');

                    for (var j = 0; j < FormFile.iStep && i + j < buf.Length; ++j)
                        sBuf[j + 1] = Convert.ToString(buf[i + j], 16);

                    if (this.eE == eEncoding.ASCII)
                    {
                        Encoding enc = Encoding.ASCII;
                        for (var j = 0; j < FormFile.iStep && i + j < buf.Length; ++j)
                            sBuf[j + 1 + FormFile.iStep] = enc.GetString(new byte[] { buf[i + j] });
                    }
                    else if (this.eE == eEncoding.Decimal)
                    {
                        for (var j = 0; j < FormFile.iStep && i + j < buf.Length; ++j)
                            sBuf[j + 1 + FormFile.iStep] = buf[i + j].ToString();
                    }
                    else if (this.eE == eEncoding.Octal)
                    {
                        for (var j = 0; j < FormFile.iStep && i + j < buf.Length; ++j)
                            sBuf[j + 1 + FormFile.iStep] = Convert.ToString(buf[i + j], 8);
                    }
                    else
                    {
                        Encoding enc = Encoding.Unicode;

                        byte[] bBuf = new byte[FormFile.iStep];
                        for (var j = 0; j < bBuf.Length && i + j < buf.Length; ++j)
                            bBuf[j] = buf[i + j];
                        string sTmp = enc.GetString(bBuf);

                        for (var j = 0; j < sTmp.Length; ++j)
                            sBuf[j + 1 + FormFile.iStep] = sTmp[j].ToString();
                    }

                    this.LWShow.Items.Add(new ListViewItem(sBuf));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit encoding
        /// </summary>
        /// <param name="newEncode"></param>
        public void EditEncoding(eEncoding newEncode)
        {
            this.eE = newEncode;
            this.Text = string.Concat(this.sPath, " + ", this.eE.ToString());
            //А вот тут изменение
        }

        /// <summary>
        /// Provides save
        /// </summary>
        public void Save(string path)
        {
            try
            {
                File.Delete(path);
                using (var bw = new BinaryWriter(File.Open(path, FileMode.CreateNew)))
                {
                    byte[] buf = new byte[FormFile.iStep];
                    foreach (ListViewItem lst in this.LWShow.Items)
                    {
                        for (var i = 1; i < FormFile.iStep + 1; ++i)
                        {
                            buf[i - 1] = Convert.ToByte(lst.SubItems[i].Text, 16);
                        }
                        bw.Write(buf);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Provides save as method
        /// </summary>
        public void SaveAs()
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                this.Save(sfd.FileName);
        }
        
        /// <summary>
        /// Provides edit value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMIEdit_Click(object sender, EventArgs e)
        {
            if (this.LWShow.SelectedItems.Count < 0)
                return;

            foreach (ListViewItem lst in this.LWShow.SelectedItems)
            {
                Provider.sAdress = lst.SubItems[0].Text;
                for (int i = 0; i < FormFile.iStep; ++i)
                {
                    Provider.sProv[i] = "";
                    Provider.sProv[i] = lst.SubItems[i + 1].Text;
                }
                var f = new FormEdit();
                f.ShowDialog();

                for (int i = 0; i < FormFile.iStep; ++i)
                {
                    lst.SubItems[i + 1].Text = Provider.sProv[i];
                }
            }
        }

        /// <summary>
        /// Provides save from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMISave_Click(object sender, EventArgs e)
        {
            this.Save(this.sPath);
        }

        /// <summary>
        /// Provides save as another file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMISaveAs_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }
    }
}
