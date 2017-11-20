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
    /// Provides edit values
    /// </summary>
    public partial class FormEdit : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormEdit()
        {
            InitializeComponent();
            this.Text = string.Concat(this.Text, " ", Provider.sAdress);

            int iIndexText = 0;

            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                if (Provider.sProv[iIndexText] == "")
                    t.Enabled = false;
                else
                    t.Text = Provider.sProv[iIndexText];
                iIndexText++;
            }
        }

        /// <summary>
        /// Event of get pressed button for labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Length > (sender as TextBox).MaxLength)
                (sender as TextBox).Text = "";
        }

        /// <summary>
        /// Event of pressed button "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int iIndexText = 0;

                foreach (TextBox t in this.Controls.OfType<TextBox>())
                {
                    if (t.Enabled == true)
                    {
                        if (t.Text == "")
                            Provider.sProv[iIndexText] = "0";
                        else
                        {
                            Convert.ToByte(Provider.sProv[iIndexText], 16); //If error - cant write this value
                            Provider.sProv[iIndexText] = t.Text;
                        }
                    }
                    iIndexText++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        /// <summary>
        /// Event of back without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
