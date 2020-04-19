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
    public partial class LearningForm : MetroForm
    {
        public LearningForm()
        {
            InitializeComponent();
        }

        private void LearningForm_Load(object sender, EventArgs e)
        {
            LeOpenCards.StyleManager = this.StyleManager;
            LeNextQuestion.StyleManager = this.StyleManager;
            LePrevQuestion.StyleManager = this.StyleManager;
            LeViewer.StyleManager = this.StyleManager;
            LeShowAnswer.StyleManager = this.StyleManager; 
        }

        private void LeOpenCards_Click(object sender, EventArgs e)
        {

        }
    }
}
