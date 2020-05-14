using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace SmartLearn
{
    public partial class EditCard : MetroForm
    {
        CardList Deck;
        int index;
        SQLiteConnection DB;
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
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            string name = this.Deck.GetName();
            int i = index++;
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = @"UPDATE " + name +" SET question= @question WHERE id= @" + i.ToString();
            CMD.Connection = new SQLiteConnection();
            CMD.Parameters.Add(new SQLiteParameter("@id", i));
            CMD.Parameters.Add(new SQLiteParameter("@question", tQuestion.Text));
            CMD.ExecuteNonQuery();
            this.Deck.GetList(index).SetQuestion(tQuestion.Text);
            this.Deck.GetList(index).SetAnswer(tAnswer.Text);
            tQuestion.Clear();
            tAnswer.Clear();




            /*string baseName = "Printers.db3";
            using (var connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source = " + baseName;
                connection.Open();
                cmd.CommandText = @"UPDATE Kollvo SET Kollvo_Cart= @Kollvo_Cart WHERE id_cart= @ID_Cart";
                cmd.Connection = connection;
                cmd.Parameters.Add(new SQLiteParameter("@ID_Cart", listBox1.SelectedValue));
                cmd.Parameters.Add(new SQLiteParameter("@Kollvo_Cart", numericUpDown1.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
            }*/
        }

        private void tQuestion_Click(object sender, EventArgs e)
        {

        }

        private void tAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
