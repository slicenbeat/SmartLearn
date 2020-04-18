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
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace SmartLearn
{
    public partial class SmartLearn : MetroForm
    {
        public SmartLearn()
        {
            InitializeComponent();
            this.StyleManager = MainStyle;
        }

        private void SmartLearn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test runner = new Test();
            runner.StyleManager = this.StyleManager;
            runner.Show();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTheme.Checked)
            {
                MainStyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else MainStyle.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            AboutApp ifrm = new AboutApp();
            ifrm.StyleManager = this.StyleManager;
            ifrm.Show(); 
        }
    }
}
