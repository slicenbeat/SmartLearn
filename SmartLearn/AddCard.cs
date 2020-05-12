using System;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace SmartLearn
{
    public partial class AddCard : MetroForm
    {
        private SQLiteConnection DB;
        CardList Deck;
        public AddCard(CardList d)
        {
            InitializeComponent();
            this.Deck = d;
        }
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
            if (tQuestion.Text != "" && tAnswer.Text != "")
            {
                DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                DB.Open();
                string name = this.Deck.GetName();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "INSERT INTO'" + name + "'(question, answer) VALUES( @question , @answer ); ";
                CMD.Parameters.Add("@question", System.Data.DbType.String).Value = tQuestion.Text;
                CMD.Parameters.Add("@answer", System.Data.DbType.String).Value = tAnswer.Text;
                CMD.ExecuteNonQuery();
            }
            Card c = new Card(tQuestion.Text, tAnswer.Text);
            this.Deck.Add(c);
            tQuestion.Clear();
            tAnswer.Clear();
        }
    }
}