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
    public partial class EditCardList : MetroForm
    {
        public EditCardList()
        {
            InitializeComponent();
        }

        private void EditCardList_Load(object sender, EventArgs e)
        {
            cListQA.StyleManager = this.StyleManager;
            bAddCard.StyleManager = this.StyleManager;
            bDeleteCard.StyleManager = this.StyleManager;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddCard addcard = new AddCard();
            addcard.StyleManager = this.StyleManager;
            addcard.Show();
        }
    }
}
