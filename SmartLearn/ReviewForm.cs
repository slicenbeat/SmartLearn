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
        bool Click;
        DataBase db;
        CardList Deck;
        Card First;
        bool Delete = false;
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
                        Click = false;
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
            if (Delete == true)
            {
                db = new DataBase();
                db.DeleteCard(Deck);
            }
        }

    

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Delete = true;
            int lv = Deck.GetList(Deck.GetCurrent()).GetLevel();
            this.Deck.GetList(Deck.GetCurrent()).SetLevelUp(lv);
            LevelLabel.Text += "";
            LevelDown.Visible = false;
            LevelUp.Visible = false;
            bNext.Visible = true;
        }

        private void LevelDown_Click(object sender, EventArgs e)
        {
            Delete = true;
            this.Deck.GetList(Deck.GetCurrent()).SetLevelDown();
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
            if (Click == false) 
            { 
            if (tQA.Text == Deck.GetList(Deck.GetCurrent()).GetQuestion()) 
                { 
                    tQA.Text = Deck.GetList(Deck.GetCurrent()).GetAnswer();
                    bShowQA.Text = "Показать вопрос";
                    LevelDown.Visible = true;
                    LevelUp.Visible = true;
                    Click = true;
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
