using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.IO;

namespace SmartLearn
{
    public partial class MyCardLists : MetroForm
    {
        CardList Deck;
        List <string> NameTable;
        DataBase db;

        public MyCardLists()
        {
            InitializeComponent();
        }


        private void MyCardLists_Load(object sender, EventArgs e)
        {
            bDeleteCardList.StyleManager = this.StyleManager;
            bEditCardList.StyleManager = this.StyleManager;
            bLearnCardList.StyleManager = this.StyleManager;
            CardListComboBox.StyleManager = this.StyleManager;
            bNewCardList.StyleManager = this.StyleManager;
            NameTable = new List<string>();
            db = new DataBase();
            try 
            { 
                db.LoadNamesOfCardLists(NameTable);
            }
            catch
            {
                db.CreateNameTable();
            }
            for (int i = 0; i < NameTable.Count; i++)
            {
                CardListComboBox.Items.Add(NameTable[i]);
            }
            if (CardListComboBox.Items.Count != 0)
            {
                CardListComboBox.SelectedIndex = 0;
            }
        }

        private void AddCardList_Click(object sender, EventArgs e)
        {
            
        }

        private void CardListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        private void bImportCardList_Click(object sender, EventArgs e)
        {

        }

        private void bExportCardList_Click(object sender, EventArgs e)
        {

        }

        private void bNewCardList_Click(object sender, EventArgs e)
        {
            CreateCardList createcardlist = new CreateCardList(NameTable);
            createcardlist.StyleManager = this.StyleManager;
            createcardlist.ShowDialog();
            CardListComboBox.Items.Clear(); 
            MyCardLists_Load(sender, e);
        }

        private void bEditCardList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardListComboBox.SelectedItem == null)
                {
                    throw new Exception();
                }

                this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
                db = new DataBase();
                db.LoadCardList(Deck);
                EditCardList editcardlist = new EditCardList(Deck);
                editcardlist.StyleManager = this.StyleManager;
                editcardlist.ShowDialog();
                CardListComboBox.Items.Clear();
                MyCardLists_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bDeleteCardList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardListComboBox.SelectedItem == null)
                {
                    throw new Exception();
                }
                int ind = CardListComboBox.Items.IndexOf(CardListComboBox.SelectedItem.ToString());
                string name = CardListComboBox.SelectedItem.ToString();
                db = new DataBase();
                db.DeleteCardList(NameTable, name, ind);
                CardListComboBox.Items.Remove(CardListComboBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bLearnCardList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardListComboBox.SelectedItem == null)
                {
                    throw new Exception();
                }
                this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
                Deck.SetCurrent(0);
                db = new DataBase();
                int size = Convert.ToInt32(db.GetCountCardList(Deck));
                if (size < 3)
                    MessageBox.Show("Для того, чтобы учить колоду, в ней должно быть не менее трёх карт.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ReviewForm reviewform = new ReviewForm(Deck);
                    reviewform.StyleManager = this.StyleManager;
                    reviewform.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MyCardLists_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            if (CardListComboBox.Text == "")
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Deck = new CardList(CardListComboBox.Text);
                db.LoadCardList(Deck);
                if (this.Deck.GetSizeofList() < 5 )
                    MessageBox.Show("Для экспорта колоды в ней должно быть не менее 5 карт.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    String result = "";
                    for (int i = 0; i < Deck.GetSizeofList(); i++)
                    {
                        result += "Вопрос: " + Deck.GetList(i).GetQuestion() + "\n" + "Ответ: " + Deck.GetList(i).GetAnswer() + "\n\n";
                    }
                    System.IO.File.WriteAllText(Deck.GetName()+".txt", result);
                    using (PrintDialog PrintDialog = new PrintDialog())
                    {
                        if (PrintDialog.ShowDialog() == DialogResult.OK)
                        {
                            ProcessStartInfo info = new ProcessStartInfo(Deck.GetName() + ".txt");
                            info.Arguments = "\"" + PrintDialog.PrinterSettings.PrinterName + "\"";
                            info.CreateNoWindow = true;
                            info.WindowStyle = ProcessWindowStyle.Hidden;
                            info.UseShellExecute = true;
                            info.Verb = "printto";
                            List<Process> l = new List<Process>();
                            l.Add(Process.Start(info));
                            while (true)
                            {
                                if (l[0].HasExited) break;
                            }
                            File.Delete(Deck.GetName() + ".txt");
                        }
                    }
                }
            }
        }
    }
}
