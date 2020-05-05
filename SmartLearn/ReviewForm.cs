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
using System.Data.SQLite;

namespace SmartLearn
{
    public partial class ReviewForm : MetroForm
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            bQA.StyleManager = this.StyleManager;
            bNext.StyleManager = this.StyleManager;
            bPrev.StyleManager = this.StyleManager;
        }

        private void bQA_Click(object sender, EventArgs e)
        {

        }
    }
}
