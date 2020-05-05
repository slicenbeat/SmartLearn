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

        public CreateCardList()
        {
            InitializeComponent();
        }

        private void CreateCardList_Load(object sender, EventArgs e)
        {
            lNameCardList.StyleManager = this.StyleManager;
            NameOfCardList.StyleManager = this.StyleManager;
            bCreateCardList.StyleManager = this.StyleManager;

        }

        private void bCreateCardList_Click(object sender, EventArgs e)
        {
            Program.mcrdlsts.CardListComboBox.Items.Add(NameOfCardList.Text);
            if(NameOfCardList.Text != "")
            {
                string S = NameOfCardList.Text;
                DB = new SQLiteConnection("Data Source=DB.db; Version=3");
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Name(NameTable) values('" + S + "')";
                CMD.ExecuteNonQuery();

                SQLiteCommand CMD1 = DB.CreateCommand();
                CMD1.CommandText = "CREATE TABLE '" + S + "' (id INTEGER PRIMARY KEY AUTOINCREMENT, question VARCHAR(1000) NOT NULL, answer VARCHAR(1000) NOT NULL); ";
                CMD1.ExecuteNonQuery();
            }

            NameOfCardList.Clear();
            NameOfCardList.Focus();

        }

        private void NameOfCardList_Click(object sender, EventArgs e)
        {
    
        }
    }
}
