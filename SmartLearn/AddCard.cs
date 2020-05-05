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
    public partial class AddCard : MetroForm
    {
        public AddCard()
        {
            InitializeComponent();
        }

        private void EditCardList_Load(object sender, EventArgs e)
        {
            tQuestion.StyleManager = this.StyleManager;
            tAnswer.StyleManager = this.StyleManager;
            bCreateCard.StyleManager = this.StyleManager;
            lAnswer.StyleManager = this.StyleManager;
            lQuestion.StyleManager = this.StyleManager;

        }

        private void tQuestion_Click(object sender, EventArgs e)
        {

        }

        private void bAddCard_Click(object sender, EventArgs e)
        {
            tQuestion.Clear();
            tAnswer.Clear();
        }
    }
}
