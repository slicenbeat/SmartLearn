﻿using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SmartLearn
{
    public partial class AboutApp : MetroForm
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        private void AboutApp_Load(object sender, EventArgs e)
        {
            GitHubLink.StyleManager = this.StyleManager;
            TextAboutApp.StyleManager = this.StyleManager;
        }
        private void GitHubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/slicenbeat/SmartLearn");
            
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

