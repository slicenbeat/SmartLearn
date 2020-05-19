using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SmartLearn
{
    public partial class EditCard : MetroForm
    {
        CardList Deck;
        int index;
        //SQLiteConnection DB;
        DataBase DB;
        public EditCard(CardList d, int i)
        {
            InitializeComponent();
            this.Deck = d;
            this.index = i;
        }

        private void EditCard_Load(object sender, EventArgs e)
        {
            tQuestion.StyleManager = this.StyleManager;
            tAnswer.StyleManager = this.StyleManager;
            bEditCard.StyleManager = this.StyleManager;
            lAnswer.StyleManager = this.StyleManager;
            lQuestion.StyleManager = this.StyleManager;

            tQuestion.Text = this.Deck.GetList(index).GetQuestion();
            tAnswer.Text = this.Deck.GetList(index).GetAnswer();
        }

        private void bEditCard_Click(object sender, EventArgs e)
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
                //DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                //DB.Open();
                //using (SQLiteConnection con = new SQLiteConnection("Data Source=DB.db; Version=3"))
                //{

                //    string name = this.Deck.GetName();

                //    SQLiteCommand CMD = DB.CreateCommand();
                //    CMD.CommandText = @"Update " + name + " Set question = '" + tQuestion.Text + "', answer = '" + tAnswer.Text + "', level = '" + Deck.Cards[index].GetLevel() + "', time = '" + Deck.Cards[index].GetTime().ToString() + "' Where id = '" + (index + 1).ToString() + "' ";
                //    CMD.Connection = con;
                //    con.Open();

                //    CMD.ExecuteNonQuery();

                //}
                DB = new DataBase();
                DB.UpdateDBCard(Deck, tQuestion.Text, tAnswer.Text, index);
                this.Deck.GetList(index).SetQuestion(tQuestion.Text);
                this.Deck.GetList(index).SetAnswer(tAnswer.Text);
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

        private void tQuestion_Click(object sender, EventArgs e)
        {

        }

        private void tAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
