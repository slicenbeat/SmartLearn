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
    public partial class EditCardList : MetroForm
    {
        private bool Delete;
        private SQLiteConnection DB;
        CardList Deck;
        public EditCardList(CardList d)
        {
            InitializeComponent();
            this.Deck = d;
        }
        public EditCardList()
        {
            InitializeComponent();
        }

        private void EditCardList_Load(object sender, EventArgs e)
        {
            cListQA.StyleManager = this.StyleManager;
            bAddCard.StyleManager = this.StyleManager;
            bEditCard.StyleManager = this.StyleManager;
            bDeleteCard.StyleManager = this.StyleManager;
            

            for (int i = 0; i < this.Deck.GetSizeofList(); i++)
            {
                cListQA.Items.Add(this.Deck.GetList(i).GetQuestion());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddCard addcard = new AddCard(Deck);
            addcard.StyleManager = this.StyleManager;
            addcard.ShowDialog();
            cListQA.Items.Clear();
            EditCardList_Load(sender, e);
        }

        private void cListQA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bDeleteCard_Click(object sender, EventArgs e)
        {
            try
            {
                Delete = true;
                this.Deck.Delete(cListQA.SelectedIndex);
                cListQA.Items.Clear();
                EditCardList_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите карточку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditCardList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Delete == true)
            {
                DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = " DROP TABLE '" + Deck.GetName() + "'; ";
                CMD.ExecuteNonQuery();


                SQLiteCommand CMD1 = DB.CreateCommand();
                CMD1.CommandText = "CREATE TABLE '" + Deck.GetName() + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL, level INTEGER NOT NULL, time VARCHAR(1000)); ";
                CMD1.ExecuteNonQuery();

                SQLiteCommand CMD2 = DB.CreateCommand();
                for (int i = 0; i < Deck.Cards.Count; i++)
                {
                    CMD2.CommandText = "insert into '" + Deck.GetName() + "'(question, answer, level, time) values( @question , @answer, @level, @time)";
                    CMD2.Parameters.Add("@question", DbType.String).Value = Deck.Cards[i].GetQuestion();
                    CMD2.Parameters.Add("@answer", DbType.String).Value = Deck.Cards[i].GetAnswer();
                    CMD2.Parameters.Add("@level", DbType.Int32).Value = Deck.Cards[i].GetLevel();
                    CMD2.Parameters.Add("@time", DbType.String).Value = Deck.Cards[i].GetTime().ToString();
                    CMD2.ExecuteNonQuery();
                }
            }
        }

        private void ChangeCard_Click_1(object sender, EventArgs e)
        {

            int index = cListQA.SelectedIndex;
            if (index < 0)
                MessageBox.Show("Выберите карточку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                EditCard editcard = new EditCard(Deck, index);
                editcard.StyleManager = this.StyleManager;
                editcard.ShowDialog();
                cListQA.Items.Clear();
                EditCardList_Load(sender, e);
            }

        }
    }
}
