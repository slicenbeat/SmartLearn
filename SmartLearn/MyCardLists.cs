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
        private SQLiteConnection DB;
        CardList Deck;
        public MyCardLists()
        {
           // Program.mcrdlsts = this;

            InitializeComponent();
        }


        private void MyCardLists_Load(object sender, EventArgs e)
        {
            bDeleteCardList.StyleManager = this.StyleManager;
            bEditCardList.StyleManager = this.StyleManager;
            bLearnCardList.StyleManager = this.StyleManager;
            CardListComboBox.StyleManager = this.StyleManager;
            bNewCardList.StyleManager = this.StyleManager;

            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From Name";
            string s = CMD.ExecuteScalar().ToString();
            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            for (int i = 1; i < size + 1; i++)
            {
                CMD1.CommandText = "SELECT * FROM Name WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                CardListComboBox.Items.Add(SQL["NameTable"].ToString());
                SQL.Close();
            }
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
            createcardlist.ShowDialog();
            CardListComboBox.Items.Clear(); 
            MyCardLists_Load(sender, e);
        }

        private void bEditCardList_Click(object sender, EventArgs e)
        {
            this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
            EditCardList editcardlist = new EditCardList(Deck);
            editcardlist.StyleManager = this.StyleManager;
            editcardlist.ShowDialog();
            CardListComboBox.Items.Clear();
            MyCardLists_Load(sender, e);
        }

        private void bDeleteCardList_Click(object sender, EventArgs e)
        {
            CardListComboBox.Items.Clear();
            MyCardLists_Load(sender, e);
        }

        private void bLearnCardList_Click(object sender, EventArgs e)
        {
            this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
            ReviewForm reviewform = new ReviewForm(Deck);
            reviewform.StyleManager = this.StyleManager;
            reviewform.ShowDialog();
        }
    }
}
