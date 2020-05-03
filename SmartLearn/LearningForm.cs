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
    public partial class LearningForm : MetroForm
    {

        private CardList Deck;
        private SQLiteConnection DB;

        public LearningForm()
        {
            InitializeComponent();
        }

        private void LearningForm_Load(object sender, EventArgs e)
        {
            LeNextQuestion.StyleManager = this.StyleManager;
            LePrevQuestion.StyleManager = this.StyleManager;
            LeViewer.StyleManager = this.StyleManager;
            LeShowAnswer.StyleManager = this.StyleManager;
            LeNextQuestion.Enabled = true;
            LePrevQuestion.Enabled = true;
            LeShowAnswer.Enabled = true;
            LeViewer.Clear();


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
            LeViewer.Text += Deck.GetList(Deck.GetCurrent()).GetQuestion();
        }

        private void LeShowAnswer_Click(object sender, EventArgs e)
        {
            LeViewer.Clear();
            LeViewer.Text += Deck.GetList(Deck.GetCurrent()).GetAnswer();
        }

        private void LeNextQuestion_Click(object sender, EventArgs e)
        {
            LeViewer.Clear();
            LeViewer.Text += Deck.GetNext().GetQuestion();
        }

        private void LePrevQuestion_Click(object sender, EventArgs e)
        {
            LeViewer.Clear();
            LeViewer.Text += Deck.GetPrev().GetQuestion();
        }

        private void LeViewer_Click(object sender, EventArgs e)
        {

        }
    }
}
