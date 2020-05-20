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
    public partial class Instruction : MetroForm
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            metroTabControl1.StyleManager = this.StyleManager;
            metroTabPage1.StyleManager = this.StyleManager;
            metroTabPage2.StyleManager = this.StyleManager;
            metroTabPage3.StyleManager = this.StyleManager;
            metroTabPage4.StyleManager = this.StyleManager;
            metroLabel1.StyleManager = this.StyleManager;
            metroLabel2.StyleManager = this.StyleManager;
            metroLabel3.StyleManager = this.StyleManager;
            metroLabel4.StyleManager = this.StyleManager;
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
