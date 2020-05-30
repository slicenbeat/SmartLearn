using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;


namespace SmartLearn
{
    public partial class ReviewForm : MetroForm
    {
        bool clicker;
        DataBase db;
        CardList Deck;
        Card First;
        bool Change = false;
        public ReviewForm(CardList d)
        {
            InitializeComponent();
            this.Deck = d;
        }
        public ReviewForm(string name)
        {
            InitializeComponent();
            this.Deck = new CardList(name);
            //db.LoadCardList(Deck);
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            LevelLabel.StyleManager = this.StyleManager;
            LevelUp.StyleManager = this.StyleManager;
            LevelDown.StyleManager = this.StyleManager;
            bShowQA.StyleManager = this.StyleManager;
            tQA.StyleManager = this.StyleManager;
            bNext.StyleManager = this.StyleManager;
            db = new DataBase();
            db.LoadCardList(Deck);
            this.Deck.Sorting();
            Deck.SetCurrent(0);
            DateTime now = DateTime.Now;
            DateTime card_now = Deck.GetList(Deck.GetCurrent()).GetTime();
            int comp = DateTime.Compare(now, card_now);

            if (comp > 0)
            {
                tQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
                First = Deck.GetList(Deck.GetCurrent());
                LevelLabel.Text = "Уровень карточки: " + Deck.GetList(Deck.GetCurrent()).GetLevel().ToString();
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path_to_txt = Path.Combine(appDataPath, "SmartLearnCompany\\SmartLearn", "NameOfLastDeck.txt");
                StreamWriter writer = new StreamWriter(path_to_txt);
                writer.Write(this.Deck.GetName());
                writer.Close();
            }
            else
            {
                tQA.Text = "Пока карт для изучения нет, зайдите позже.";
                LevelLabel.Text = "";
                bNext.Enabled = false;
                bShowQA.Visible = false;
            }
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            bShowQA.Text = "Показать ответ";
            while (true)
            {
                Card Next = Deck.GetNext();
                if (Next.GetQuestion() == First.GetQuestion())
                {
                    tQA.Text = "Пока карт для изучения нет, зайдите позже.";
                    LevelLabel.Text = "";
                    bNext.Visible = false;
                    bShowQA.Visible = false;
                    break;
                }
                else 
                {
                    DateTime now = DateTime.Now;
                    DateTime card_now = Deck.GetList(Deck.GetCurrent()).GetTime();
                    int comp = DateTime.Compare(now, card_now);

                    if (comp > 0)
                    {
                        tQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
                        LevelLabel.Text = "Уровень карточки: " + Deck.GetList(Deck.GetCurrent()).GetLevel().ToString();
                        //bQA.Enabled = true;
                        bNext.Visible = false;
                        clicker = false;
                        break;
                    }
                }
            }
        }


        private void ReviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ReviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Change == true)
            {
                db = new DataBase();
                db.DeleteCard(Deck);
            }
        }

    

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Change = true;
            int lv = Deck.GetList(Deck.GetCurrent()).GetLevel();
            this.Deck.GetList(Deck.GetCurrent()).SetLevelUp(lv);
            if (lv == 8) LevelLabel.Text = "Уровень карточки: " + (lv).ToString();
            else LevelLabel.Text = "Уровень карточки: " + (lv+1).ToString();
            LevelDown.Visible = false;
            LevelUp.Visible = false;
            bNext.Visible = true;
        }

        private void LevelDown_Click(object sender, EventArgs e)
        {
            Change = true;
            this.Deck.GetList(Deck.GetCurrent()).SetLevelDown();
            LevelLabel.Text = "Уровень карточки: 0";
            LevelDown.Visible = false;
            LevelUp.Visible = false;
            bNext.Visible = true;
        }

        private void LevelLabel_Click(object sender, EventArgs e)
        {

        }

        private void tQA_Click(object sender, EventArgs e)
        {

        }

        private void bShowQA_Click(object sender, EventArgs e)
        {
            if (clicker == false) 
            { 
            if (tQA.Text == Deck.GetList(Deck.GetCurrent()).GetQuestion()) 
                { 
                    tQA.Text = Deck.GetList(Deck.GetCurrent()).GetAnswer();
                    bShowQA.Text = "Показать вопрос";
                    LevelDown.Visible = true;
                    LevelUp.Visible = true;
                    clicker = true;
                }
            }
            else
            {
                if (tQA.Text == Deck.GetList(Deck.GetCurrent()).GetQuestion())
                {
                    tQA.Text = Deck.GetList(Deck.GetCurrent()).GetAnswer();
                    bShowQA.Text = "Показать вопрос";
                }
                else
                {
                    tQA.Text = Deck.GetList(Deck.GetCurrent()).GetQuestion();
                    bShowQA.Text = "Показать ответ";
                }
            }
        }
    }
}
