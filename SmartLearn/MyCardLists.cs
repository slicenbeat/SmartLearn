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
            bDeleteCardList.StyleManager = this.StyleManager;
            bEditCardList.StyleManager = this.StyleManager;
            bLearnCardList.StyleManager = this.StyleManager;
            CardListComboBox.StyleManager = this.StyleManager;
            bExportCardList.StyleManager = this.StyleManager;
            bImportCardList.StyleManager = this.StyleManager;
            bNewCardList.StyleManager = this.StyleManager;
        }

        private void AddCardList_Click(object sender, EventArgs e)
        {
            
        }

        private void CardListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        private void bImportCardList_Click(object sender, EventArgs e)
        {

        }

        private void bExportCardList_Click(object sender, EventArgs e)
        {

        }

        private void bNewCardList_Click(object sender, EventArgs e)
        {
            CreateCardList createcardlist = new CreateCardList();
            createcardlist.StyleManager = this.StyleManager;
            createcardlist.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            EditCardList editcardlist = new EditCardList();
            editcardlist.StyleManager = this.StyleManager;
            editcardlist.Show();
        }

        private void bDeleteCardList_Click(object sender, EventArgs e)
        {

        }

        private void bLearnCardList_Click(object sender, EventArgs e)
        {
            ReviewForm reviewform = new ReviewForm();
            reviewform.StyleManager = this.StyleManager;
            reviewform.Show();
        }
    }
}
