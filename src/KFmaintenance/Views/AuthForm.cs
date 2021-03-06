﻿using KFlearning.Core.Extensions;
using KFmaintenance.Properties;
using System.Windows.Forms;

namespace KFmaintenance.Views
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, System.EventArgs e)
        {
            DialogResult = HashHelpers.CompareHash(txtCode.Text, Settings.Default.Password) 
                ? DialogResult.OK 
                : DialogResult.Abort;
            Close();
        }
    }
}