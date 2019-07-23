using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DialogueExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogForm dialogForm = new DialogForm();
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
                xm.Text = dialogForm.UserName;
                nl.Text = dialogForm.UserAge.ToString();
            }
            dialogForm.Dispose();
        }
    }
}
