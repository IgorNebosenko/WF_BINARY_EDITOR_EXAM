using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BINARY_EDITOR_EXAM
{
    /// <summary>
    /// AboutBox
    /// </summary>
    partial class AboutBox : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AboutBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// if pressed on link label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LLBGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IgorNebosenko/WF_BINARY_EDITOR_EXAM");
        }
    }
}
