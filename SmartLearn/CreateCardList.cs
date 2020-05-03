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
    public partial class CreateCardList : MetroForm
    {
        CardList Deck;
        public CreateCardList()
        {
            InitializeComponent();
        }

        private void CreateCardList_Load(object sender, EventArgs e)
        {
            lNameCardList.StyleManager = this.StyleManager;
            NameOfCardList.StyleManager = this.StyleManager;
            bCreateCardList.StyleManager = this.StyleManager;

        }

        private void bCreateCardList_Click(object sender, EventArgs e)
        {
            Program.mcrdlsts.CardListComboBox.Items.Add(NameOfCardList.Text);
            Deck = new CardList(NameOfCardList.Text);
            NameOfCardList.Clear();
            NameOfCardList.Focus();

        }

        private void NameOfCardList_Click(object sender, EventArgs e)
        {
    
        }
    }
}
