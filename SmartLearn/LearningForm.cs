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
//
namespace SmartLearn
{
    public partial class LearningForm : MetroForm
    {

        private Cards Deck;
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
            Deck = new Cards("table_1", 4);
            Deck.setNumber(1);
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM '" + Deck.getName() + "'  WHERE id = 1";
            //CMD.Parameters.Add("@Name", DbType.String).Value = Deck.getName();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            SQL.Read();
            LeViewer.Text += SQL["question"];
        }

        private void LeShowAnswer_Click(object sender, EventArgs e)
        {
            LeViewer.Clear();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM '" + Deck.getName() + "' WHERE id like '%' || @Numb || '%' ";
            CMD.Parameters.Add("@Numb", DbType.Int16).Value = Deck.getNumber();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {

                SQL.Read();
                LeViewer.Text += SQL["answer"];

            }
            else LeViewer.Text = "Error";
        }

        private void LeNextQuestion_Click(object sender, EventArgs e)
        {
            LeViewer.Clear();
            Deck.nextID();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM '" + Deck.getName() + "' WHERE id like '%' || @Numb || '%' ";
            CMD.Parameters.Add("@Numb", DbType.Int16).Value = Deck.getNumber();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {

                SQL.Read();
                LeViewer.Text += SQL["question"];

            }
            else LeViewer.Text = "Error";
        }

        private void LePrevQuestion_Click(object sender, EventArgs e)
        {
            LeViewer.Clear();
            Deck.prevID();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT * FROM '" + Deck.getName() + "' WHERE id like '%' || @Numb || '%' ";
            CMD.Parameters.Add("@Numb", DbType.Int16).Value = Deck.getNumber();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {

                SQL.Read();
                LeViewer.Text += SQL["question"];

            }
            else LeViewer.Text = "Error";
        }
    }
}
