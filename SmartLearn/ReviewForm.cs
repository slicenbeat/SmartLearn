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
using System.IO;


namespace SmartLearn
{
    public partial class ReviewForm : MetroForm
    {
        private SQLiteConnection DB;
        DataBase db;
        CardList Deck;
        Card First;
        bool Delete = false;
        public ReviewForm(CardList d)
        {
            InitializeComponent();
            this.Deck = d;
        }
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            bQA.StyleManager = this.StyleManager;
            bNext.StyleManager = this.StyleManager;
            bPrev.StyleManager = this.StyleManager;
            Deck.SetCurrent(0);
            db = new DataBase();
            db.LoadCardList(Deck);
            //DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            //DB.Open();
            //SQLiteCommand CMD = DB.CreateCommand();
            //CMD.CommandText = "SELECT Count(*) From " + '\u0022' + Deck.GetName() + '\u0022';
            //string s = CMD.ExecuteScalar().ToString();

            //int size = Convert.ToInt32(s);

            //SQLiteCommand CMD1 = DB.CreateCommand();
            //SQLiteDataReader SQL;
            //for (int i = 1; i < size + 1; i++)
            //{
            //    CMD1.CommandText = "SELECT * FROM " + '\u0022' + Deck.GetName() + '\u0022' + " WHERE id like '%' || @Numb || '%' ";
            //    CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;
            //    SQL = CMD1.ExecuteReader();
            //    SQL.Read();
            //    DateTime T = DateTime.Parse(SQL["time"].ToString());
            //    Card C = new Card(SQL["question"].ToString(), SQL["answer"].ToString(), T, Int32.Parse(SQL["level"].ToString()));
            //    this.Deck.Add(C);
            //    SQL.Close();
            //}
            this.Deck.Sorting();
            DateTime now = DateTime.Now;
            DateTime card_now = Deck.GetList(Deck.GetCurrent()).GetTime();
            int comp = DateTime.Compare(now, card_now);

            if (comp > 0)
            {
                bQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
                First = Deck.GetList(Deck.GetCurrent());
                LevelLabel.Text = "Уровень карточки: " + Deck.GetList(Deck.GetCurrent()).GetLevel().ToString();
            }
            else
            {
                bQA.Text = "Новых к изучению карт нет.";
                bNext.Enabled = false;
                bPrev.Enabled = false;
                bQA.Enabled = false;
            }
        }

        private void bQA_Click(object sender, EventArgs e)
        {
            //if (bQA.Text == Deck.GetList(Deck.GetCurrent()).GetQuestion())
            //{
                bQA.Text = Deck.GetList(Deck.GetCurrent()).GetAnswer();
                LevelDown.Visible = true;
                LevelUp.Visible = true;
                bQA.Enabled = false;

            //}
            //else
            //    bQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Card Next = Deck.GetNext();
                if (Next.GetQuestion() == First.GetQuestion())
                {
                    bQA.Text = "Новых к изучению карт нет.";
                    bNext.Visible = false;
                    bPrev.Enabled = false;
                    bQA.Enabled = false;
                    break;
                }
                else 
                {
                    DateTime now = DateTime.Now;
                    DateTime card_now = Deck.GetList(Deck.GetCurrent()).GetTime();
                    int comp = DateTime.Compare(now, card_now);

                    if (comp > 0)
                    {
                        bQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
                        LevelLabel.Text = "Уровень карточки: " + Deck.GetList(Deck.GetCurrent()).GetLevel().ToString();
                        bQA.Enabled = true;
                        bNext.Visible = false;
                        break;
                    }
                }
            }
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            bQA.Text = Deck.GetPrev().GetQuestion();
        }

        private void ReviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string file = "DeckName.txt";
            //using (StreamWriter writer = new StreamWriter(file, false, Encoding.GetEncoding(1251)))
            //{
            //    writer.WriteLine(this.Deck.GetName());
            //}

            if (Delete == true)
            {
                db = new DataBase();
                db.DeleteCard(Deck);

                //DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                //DB.Open();
                //SQLiteCommand CMD = DB.CreateCommand();
                //CMD.CommandText = " DROP TABLE '" + Deck.GetName() + "'; ";
                //CMD.ExecuteNonQuery();


                //SQLiteCommand CMD1 = DB.CreateCommand();
                //CMD1.CommandText = "CREATE TABLE '" + Deck.GetName() + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL, level INTEGER NOT NULL, time VARCHAR(1000)); ";
                //CMD1.ExecuteNonQuery();

                //SQLiteCommand CMD2 = DB.CreateCommand();
                //for (int i = 0; i < Deck.Cards.Count; i++)
                //{
                //    CMD2.CommandText = "insert into '" + Deck.GetName() + "'(question, answer, level, time) values( @question , @answer, @level, @time)";
                //    CMD2.Parameters.Add("@question", DbType.String).Value = Deck.Cards[i].GetQuestion();
                //    CMD2.Parameters.Add("@answer", DbType.String).Value = Deck.Cards[i].GetAnswer();
                //    CMD2.Parameters.Add("@level", DbType.Int32).Value = Deck.Cards[i].GetLevel();
                //    CMD2.Parameters.Add("@time", DbType.String).Value = Deck.Cards[i].GetTime().ToString();
                //    CMD2.ExecuteNonQuery();
                //}
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            bQA.Text = Deck.GetNextRandom().GetQuestion();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Delete = true;
            int lv = Deck.GetList(Deck.GetCurrent()).GetLevel();
            this.Deck.GetList(Deck.GetCurrent()).SetLevelUp(lv);
            LevelDown.Visible = false;
            LevelUp.Visible = false;
            bNext.Visible = true;
        }

        private void LevelDown_Click(object sender, EventArgs e)
        {
            Delete = true;
            this.Deck.GetList(Deck.GetCurrent()).SetLevelDown();
            LevelDown.Visible = false;
            LevelUp.Visible = false;
            bNext.Visible = true;
        }
    }
}
