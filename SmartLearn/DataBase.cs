using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SmartLearn
{
    class DataBase
    {
        SQLiteConnection DB;
        public void LoadCardList(CardList D)        // Перенос имнофрмации из бд в объект CardList D
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath,"SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            D.SetCurrent(1);
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From " + '\u0022' + D.GetName() + '\u0022';      // Количество строк в таблице бд
            string s = CMD.ExecuteScalar().ToString();

            int size = Convert.ToInt32(s);

            SQLiteCommand CMD1 = DB.CreateCommand();
            SQLiteDataReader SQL;
            for (int i = 1; i < size + 1; i++)
            {
                CMD1.CommandText = "SELECT * FROM " + '\u0022' + D.GetName() + '\u0022' + " WHERE id like '%' || @Numb || '%' ";    // Выбрать строку таблицы бд в номером i
                CMD1.Parameters.Add("@Numb", DbType.Int16).Value = i;                                                               //
                SQL = CMD1.ExecuteReader();                                                                                         //
                SQL.Read();                                                                                                         //
                DateTime T = DateTime.Parse(SQL["time"].ToString());                                                                //
                Card C = new Card(SQL["question"].ToString(), SQL["answer"].ToString(), T, Int32.Parse(SQL["level"].ToString()));   // и перенести информацию из этой строки в объект Card C
                D.Add(C);
                SQL.Close();
            }
        }

        public void UpdateCard(CardList d, string q, string ans, int index)     // Изменение строки в бд
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath + "; Version=3"))
            {
                string name = d.GetName();
                SQLiteCommand CMD = DB.CreateCommand();
                // Изменение всех полей строки с номером index в колоде
                CMD.CommandText = @"Update '" + name + "' Set question = '" + q + "', answer = '" + ans + "', level = '" + d.Cards[index].GetLevel() + "', time = '" + d.Cards[index].GetTime().ToString() + "' Where id = '" + (index + 1).ToString() + "' ";
                CMD.Connection = con;
                con.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public void DeleteCardList(List <string> NameTable, string CurrentName, int index)      // Удаление колоды
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = " DROP TABLE '" + CurrentName + "'; ";        // Удаление колоды с именем CurrentName
            CMD.ExecuteNonQuery();
            NameTable.RemoveAt(index);

            SQLiteCommand CMD3 = DB.CreateCommand();
            CMD3.CommandText = " DROP TABLE 'Name'; ";                      // Удаление таблицы с именами колод
            CMD3.ExecuteNonQuery();
            SQLiteCommand CMD1 = DB.CreateCommand();    
                                                                            // Создание новой таблицы с именами
            CMD1.CommandText = "CREATE TABLE 'Name' (id INTEGER PRIMARY KEY AUTOINCREMENT, NameTable VARCHAR(1000) NOT NULL); ";
            CMD1.ExecuteNonQuery();
            SQLiteCommand CMD2 = DB.CreateCommand();
            for (int i = 0; i < NameTable.Count; i++)                       // Заполнение новой таблицы с именами
            {
                CMD2.CommandText = "insert into 'Name'(NameTable) values(@NameTable)";
                CMD2.Parameters.Add("@NameTable", DbType.String).Value = NameTable[i];
                CMD2.ExecuteNonQuery();
            }
        }

        public void InsertCard(CardList D, DateTime t, string q, string ans)        // Добавление карты
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            string name = D.GetName();
            SQLiteCommand CMD = DB.CreateCommand();
            // Добавление карты в конец колоды
            CMD.CommandText = "INSERT INTO'" + name + "'(question, answer, level, time) VALUES( @question , @answer , @level , @time ); ";
            CMD.Parameters.Add("@question", System.Data.DbType.String).Value = q;
            CMD.Parameters.Add("@answer", System.Data.DbType.String).Value = ans;
            CMD.Parameters.Add("@level", System.Data.DbType.Int32).Value = 0;
            CMD.Parameters.Add("@time", System.Data.DbType.String).Value = t.ToString();
            CMD.ExecuteNonQuery();
        }

        public void UpdateCardList(CardList Deck)       // Удаление колоды
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = " DROP TABLE '" + Deck.GetName() + "'; ";         // Удаление колоды
            CMD.ExecuteNonQuery();


            SQLiteCommand CMD1 = DB.CreateCommand();
            // Создание колоды с таким же именем
            CMD1.CommandText = "CREATE TABLE '" + Deck.GetName() + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL, level INTEGER NOT NULL, time VARCHAR(1000)); ";
            CMD1.ExecuteNonQuery();

            SQLiteCommand CMD2 = DB.CreateCommand();
            for (int i = 0; i < Deck.Cards.Count; i++)                          // Перезапись колоды без удаленной карты
            {
                CMD2.CommandText = "insert into '" + Deck.GetName() + "'(question, answer, level, time) values( @question , @answer, @level, @time)";
                CMD2.Parameters.Add("@question", DbType.String).Value = Deck.Cards[i].GetQuestion();
                CMD2.Parameters.Add("@answer", DbType.String).Value = Deck.Cards[i].GetAnswer();
                CMD2.Parameters.Add("@level", DbType.Int32).Value = Deck.Cards[i].GetLevel();
                CMD2.Parameters.Add("@time", DbType.String).Value = Deck.Cards[i].GetTime().ToString();
                CMD2.ExecuteNonQuery();
            }
        }

        public void LoadNamesOfCardLists(List <string> NameTable)       // Добавление имен колоды в лист
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From Name";      // Получили количество строк колоды с именами
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
                NameTable.Add(SQL["NameTable"].ToString());     // Добавляем имена колод в лист
                SQL.Close();
            }
        }

        public void CreateCardList(string S)        // Создание новой колоды
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "insert into Name(NameTable) values('" + S + "')";        // Добавление имени новой колоды в колоду с именами
            CMD.ExecuteNonQuery();

            SQLiteCommand CMD1 = DB.CreateCommand();
            // Создание колоды с заданным именем
            CMD1.CommandText = "CREATE TABLE '" + S + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL, level INTEGER NOT NULL, time VARCHAR(1000) ); ";
            CMD1.ExecuteNonQuery();
        }

        public string GetCountCardList(CardList deck)       // Вернуть количество строк в колоде
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "SELECT Count(*) From " + '\u0022' + deck.GetName() + '\u0022';
            return CMD.ExecuteScalar().ToString();

        }

        public void CreateNameTable()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "SmartLearn", "DB.db");
            DB = new SQLiteConnection("Data Source=" + dbPath + "; Version=3");

            DB.Open();
            SQLiteCommand CMD1 = DB.CreateCommand();
            // Создание новой таблицы с именами
            CMD1.CommandText = "CREATE TABLE 'Name' (id INTEGER PRIMARY KEY AUTOINCREMENT, NameTable VARCHAR(1000) NOT NULL); ";
            CMD1.ExecuteNonQuery();
        }
    }
}