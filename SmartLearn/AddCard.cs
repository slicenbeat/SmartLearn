using System;
using MetroFramework.Forms;
using System.Data.SQLite;
using System.Windows.Forms;

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
            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;
            for (int i = 0; i < this.Deck.GetSizeofList(); i++)
            {
                if (tQuestion.Text == "" || tAnswer.Text == "")
                    flag1 = false;
                else if (tQuestion.Text == this.Deck.GetList(i).GetQuestion())
                    flag2 = false;
                else if (tQuestion.Text.Length > 100 || tAnswer.Text.Length > 1000)
                    flag3 = false;
            }
            if ((flag1) && (flag2) && (flag3))
            {
                DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                DB.Open();
                string name = this.Deck.GetName();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "INSERT INTO'" + name + "'(question, answer, level, time) VALUES( @question , @answer , @level , @time ); ";
                CMD.Parameters.Add("@question", System.Data.DbType.String).Value = tQuestion.Text;
                CMD.Parameters.Add("@answer", System.Data.DbType.String).Value = tAnswer.Text;
                CMD.Parameters.Add("@level", System.Data.DbType.Int32).Value = 0;
                DateTime T = DateTime.Now;
                CMD.Parameters.Add("@time", System.Data.DbType.String).Value = T.ToString();
                CMD.ExecuteNonQuery();
                Card c = new Card(tQuestion.Text, tAnswer.Text, T, 0);
                this.Deck.Add(c);
                tQuestion.Clear();
                tAnswer.Clear();
            }
            else
            {
                if (!flag1)
                    MessageBox.Show("Поля вопроса и ответа не могут быть пустыми.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag2)
                    MessageBox.Show("Не могут существовать карточки с одинаковыми вопросами", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag3)
                    MessageBox.Show("Вы превысили ограничение по символам\nОграничение для вопроса: 100 (у вас " 
                        + tQuestion.Text.Length + ")\nОграничение для ответа: 1000 (у вас " 
                        + tAnswer.Text.Length + ")", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}