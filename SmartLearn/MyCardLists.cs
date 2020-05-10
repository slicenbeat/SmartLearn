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
        List <string> NameTable;
        public MyCardLists()
        {
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
            NameTable = new List<string>();
            for (int i = 0; i < size; i++)
            {
                CMD1.CommandText = "SELECT * FROM Name WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i+1;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                CardListComboBox.Items.Add(SQL["NameTable"].ToString());
                NameTable.Add(SQL["NameTable"].ToString());
                SQL.Close();
            }
            if (CardListComboBox.Items.Count != 0)
            {
                CardListComboBox.SelectedIndex = 0;
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

            Deck.SetCurrent(1);
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From " + '\u0022' + Deck.GetName() + '\u0022';
            string s = CMD.ExecuteScalar().ToString();

            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            for (int i = 1; i < size + 1; i++)
            {
                CMD1.CommandText = "SELECT * FROM " + '\u0022' + Deck.GetName() + '\u0022' + " WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                Card C = new Card(SQL["question"].ToString(), SQL["answer"].ToString());
                this.Deck.Add(C);
                SQL.Close();
            }

            EditCardList editcardlist = new EditCardList(Deck);
            editcardlist.StyleManager = this.StyleManager;
            editcardlist.ShowDialog();
            CardListComboBox.Items.Clear();
            MyCardLists_Load(sender, e);
        }

        private void bDeleteCardList_Click(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = " DROP TABLE '" + CardListComboBox.SelectedItem.ToString() + "'; ";
            CMD.ExecuteNonQuery();
            NameTable.RemoveAt(CardListComboBox.Items.IndexOf(CardListComboBox.SelectedItem.ToString()));
            CardListComboBox.Items.Remove(CardListComboBox.SelectedItem.ToString());
            
            SQLiteCommand CMD3 = DB.CreateCommand();
            CMD3.CommandText = " DROP TABLE 'Name'; ";
            CMD3.ExecuteNonQuery();
            SQLiteCommand CMD1 = DB.CreateCommand();
            CMD1.CommandText = "CREATE TABLE 'Name' (id INTEGER PRIMARY KEY AUTOINCREMENT, NameTable VARCHAR(1000) NOT NULL); ";
            CMD1.ExecuteNonQuery();
            SQLiteCommand CMD2 = DB.CreateCommand();
            for (int i = 0; i < NameTable.Count; i++)
            {
                CMD2.CommandText = "insert into 'Name'(NameTable) values(@NameTable)";
                CMD2.Parameters.Add("@NameTable", DbType.String).Value = NameTable[i];
                CMD2.ExecuteNonQuery();
            }

        }

        private void bLearnCardList_Click(object sender, EventArgs e)
        {
            this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
            ReviewForm reviewform = new ReviewForm(Deck);
            reviewform.StyleManager = this.StyleManager;
            reviewform.ShowDialog();
        }

        private void MyCardLists_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = " DROP TABLE 'Name'; ";
            CMD.ExecuteNonQuery();


            SQLiteCommand CMD1 = DB.CreateCommand();
            CMD1.CommandText = "CREATE TABLE 'Name' (id INTEGER PRIMARY KEY AUTOINCREMENT, NameTable VARCHAR(1000) NOT NULL); ";
            CMD1.ExecuteNonQuery();

            SQLiteCommand CMD2 = DB.CreateCommand();
            for (int i = 0; i < NameTable.Count; i++)
            {
                CMD2.CommandText = "insert into 'Name'(NameTable) values( @NameTable)";
                CMD2.Parameters.Add("@NameTable", DbType.String).Value = NameTable[i];
                CMD2.ExecuteNonQuery();
            }*/
        }
    }
}
