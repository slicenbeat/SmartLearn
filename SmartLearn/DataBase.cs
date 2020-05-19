using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SmartLearn
{
    class DataBase
    {
        SQLiteConnection DB;
        public void LoadFromDBCard(CardList D)
        {
            D.SetCurrent(1);
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From " + '\u0022' + D.GetName() + '\u0022';
            string s = CMD.ExecuteScalar().ToString();

            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            for (int i = 1; i < size + 1; i++)
            {
                CMD1.CommandText = "SELECT * FROM " + '\u0022' + D.GetName() + '\u0022' + " WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                DateTime T = DateTime.Parse(SQL["time"].ToString());
                Card C = new Card(SQL["question"].ToString(), SQL["answer"].ToString(), T, Int32.Parse(SQL["level"].ToString()));
                D.Add(C);
                SQL.Close();
            }
        }

        public void UpdateDBCard(CardList d, string q, string ans, int index)
        {
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=DB.db; Version=3"))
            {
                string name = d.GetName();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = @"Update " + name + " Set question = '" + q + "', answer = '" + ans + "', level = '" + d.Cards[index].GetLevel() + "', time = '" + d.Cards[index].GetTime().ToString() + "' Where id = '" + (index + 1).ToString() + "' ";
                CMD.Connection = con;
                con.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public void DeleteDeckFromDB(List <string> NameTable, string CurrentName, int index)
        {
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = " DROP TABLE '" + CurrentName + "'; ";
            CMD.ExecuteNonQuery();
            NameTable.RemoveAt(index);
            //CardListComboBox.Items.Remove(CardListComboBox.SelectedItem.ToString());

            SQLiteCommand CMD3 = DB.CreateCommand();
            CMD3.CommandText = " DROP TABLE 'Name'; ";
            CMD3.ExecuteNonQuery();
            SQLiteCommand CMD1 = DB.CreateCommand();
            CMD1.CommandText = "CREATE TABLE 'Name' (id INTEGER PRIMARY KEY AUTOINCREMENT, NameTable VARCHAR(1000) NOT NULL); ";
            CMD1.ExecuteNonQuery();
            SQLiteCommand CMD2 = DB.CreateCommand();
            for (int i = 0; i < NameTable.Count; i++)
            {
                CMD2.CommandText = "insert into 'Name'(NameTable) values(@NameTable)";
                CMD2.Parameters.Add("@NameTable", DbType.String).Value = NameTable[i];
                CMD2.ExecuteNonQuery();
            }
        }

        public void SaveInDBCard(CardList D, DateTime t, string q, string ans)
        {
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            string name = D.GetName();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "INSERT INTO'" + name + "'(question, answer, level, time) VALUES( @question , @answer , @level , @time ); ";
            CMD.Parameters.Add("@question", System.Data.DbType.String).Value = q;
            CMD.Parameters.Add("@answer", System.Data.DbType.String).Value = ans;
            CMD.Parameters.Add("@level", System.Data.DbType.Int32).Value = 0;
            CMD.Parameters.Add("@time", System.Data.DbType.String).Value = t.ToString();
            CMD.ExecuteNonQuery();
        }

        public void DeleteCardInDB(CardList Deck)
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

        public void LoadNameOfDecks(List <string> NameTable)
        {
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From Name";
            string s = CMD.ExecuteScalar().ToString();
            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            //NameTable = new List<string>();
            for (int i = 0; i < size; i++)
            {
                CMD1.CommandText = "SELECT * FROM Name WHERE id like '%' || @Numb || '%' ";
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i + 1;
                SQL = CMD1.ExecuteReader();
                SQL.Read();
                //CardListComboBox.Items.Add(SQL["NameTable"].ToString());
                NameTable.Add(SQL["NameTable"].ToString());
                SQL.Close();
            }
        }

        public void CreateDeckInDB(string S)
        {
            DB = new SQLiteConnection("Data Source=DB.db; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "insert into Name(NameTable) values('" + S + "')";
            CMD.ExecuteNonQuery();

            SQLiteCommand CMD1 = DB.CreateCommand();
            CMD1.CommandText = "CREATE TABLE '" + S + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL, level INTEGER NOT NULL, time VARCHAR(1000) ); ";
            CMD1.ExecuteNonQuery();
        }
    }
}
