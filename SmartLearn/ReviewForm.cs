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

            Deck = new CardList("table_1");
            Deck.SetCurrent(1);
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From table_1";
            string s = CMD.ExecuteScalar().ToString();

            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            for (int i = 1; i < size + 1; i++)
            {
                CMD1.CommandText = "SELECT * FROM table_1 WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                Card C = new Card(SQL["question"].ToString(), SQL["answer"].ToString());
                this.Deck.Add(C);
                SQL.Close();
            }
            ReviewForm.Text += Deck.GetList(Deck.GetCurrent()).GetQuestion();
        }

        private void bQA_Click(object sender, EventArgs e)
        {
           
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            ReviewForm.Clear();
            ReviewForm.Text += Deck.GetNext().GetQuestion();
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            ReviewForm.Clear();
            ReviewForm.Text += Deck.GetPrev().GetQuestion();
        }
    }
}
