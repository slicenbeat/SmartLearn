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
    public partial class MyCardLists : MetroForm
    {
        public MyCardLists()
        {
            Program.mcrdlsts = this;

            InitializeComponent();
        }


        private void MyCardLists_Load(object sender, EventArgs e)
        {
            bAddCardList.StyleManager = this.StyleManager;
            bDeleteCardList.StyleManager = this.StyleManager;
            bEditCardList.StyleManager = this.StyleManager;
            bLearnCardList.StyleManager = this.StyleManager;
            CardListComboBox.StyleManager = this.StyleManager;

        }

        private void AddCardList_Click(object sender, EventArgs e)
        {
            CreateCardList createcardlist = new CreateCardList();
            createcardlist.StyleManager = this.StyleManager;
            createcardlist.Show();
        }

        private void CardListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CardListComboBox.Items.Remove(CardListComboBox.SelectedItem);
        }

        private void bLearnCardList_Click(object sender, EventArgs e)
        {
            ReviewForm reviewform = new ReviewForm();
            reviewform.StyleManager = this.StyleManager;
            reviewform.Show();
        }
    }
}
