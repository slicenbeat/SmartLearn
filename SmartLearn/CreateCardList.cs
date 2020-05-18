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
   

    public partial class CreateCardList : MetroForm
    {
        private SQLiteConnection DB;
        List<string> NameTable;
        public CreateCardList()
        {
            InitializeComponent();
        }
        public CreateCardList(List<string> nt)
        {
            InitializeComponent();
            this.NameTable = nt;
        }

        private void CreateCardList_Load(object sender, EventArgs e)
        {
            lNameCardList.StyleManager = this.StyleManager;
            NameOfCardList.StyleManager = this.StyleManager;
            bCreateCardList.StyleManager = this.StyleManager;

        }

        private void bCreateCardList_Click(object sender, EventArgs e)
        {
            string S = NameOfCardList.Text;
            bool flag1 = true;
            bool flag2 = true;
            for (int i = 0; i < NameTable.Count(); i++)
            {
                if (S == NameTable[i])
                    flag1 = false;
                else if (S == "")
                    flag2 = false;
            }
            if ((flag1) && (flag2))
            {
                DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Name(NameTable) values('" + S + "')";
                CMD.ExecuteNonQuery();

                SQLiteCommand CMD1 = DB.CreateCommand();
                CMD1.CommandText = "CREATE TABLE '" + S + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL, level INTEGER NOT NULL, time VARCHAR(1000) ); ";
                CMD1.ExecuteNonQuery();
                NameOfCardList.Clear();
                NameOfCardList.Focus();
            }
            else
            {
                if (!flag1)
                    MessageBox.Show("Нельзя создавать несколько колод с одинаковыми названиями.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag2)
                MessageBox.Show("У колоды должно быть название.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NameOfCardList_Click(object sender, EventArgs e)
        {
    
        }
    }
}
