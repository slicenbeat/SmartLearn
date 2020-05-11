using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace SmartLearn
{
    public partial class EditCard : MetroForm
    {
        public EditCard()
        {
            InitializeComponent();
        }

        private void EditCard_Load(object sender, EventArgs e)
        {
            tQuestion.StyleManager = this.StyleManager;
            tAnswer.StyleManager = this.StyleManager;
            bEditCard.StyleManager = this.StyleManager;
            lAnswer.StyleManager = this.StyleManager;
            lQuestion.StyleManager = this.StyleManager;
        }

        private void bEditCard_Click(object sender, EventArgs e)
        {

        }
    }
}
