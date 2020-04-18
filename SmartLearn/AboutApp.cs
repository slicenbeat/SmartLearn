using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

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

        private void HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

