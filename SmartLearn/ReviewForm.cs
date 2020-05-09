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
        CardList Deck;
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

            //Deck = new CardList("table_1");
            Deck.SetCurrent(1);
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From " + '\u0022'+ Deck.GetName() + '\u0022';
            string s = CMD.ExecuteScalar().ToString();

            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            for (int i = 1; i < size + 1; i++)
            {
                CMD1.CommandText = "SELECT * FROM " +'\u0022' + Deck.GetName() + '\u0022'+ " WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                Card C = new Card(SQL["question"].ToString(), SQL["answer"].ToString());
                this.Deck.Add(C);
                SQL.Close();
            }
            bQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
        }

        private void bQA_Click(object sender, EventArgs e)
        {
           if (bQA.Text == Deck.GetList(Deck.GetCurrent()).GetQuestion())
                bQA.Text = Deck.GetList(Deck.GetCurrent()).GetAnswer();
           else
                bQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            bQA.Text = Deck.GetNext().GetQuestion();
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
            string file = "DeckName.txt";
            using (StreamWriter writer = new StreamWriter(file, false, Encoding.GetEncoding(1251)))
            {
                writer.WriteLine(this.Deck.GetName());
            }
        }
    }
}
