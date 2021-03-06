﻿using System;
using MetroFramework.Forms;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SmartLearn
{
    public partial class AddCard : MetroForm
    {
        CardList Deck;
        DataBase db;
        public AddCard(CardList d)
        {
            InitializeComponent();
            this.Deck = d;
        }
        public AddCard()
        {
            InitializeComponent();
        }

        private void EditCardList_Load(object sender, EventArgs e)
        {
            tQuestion.StyleManager = this.StyleManager;
            tAnswer.StyleManager = this.StyleManager;
            bCreateCard.StyleManager = this.StyleManager;
            lAnswer.StyleManager = this.StyleManager;
            lQuestion.StyleManager = this.StyleManager;

        }

        private void tQuestion_Click(object sender, EventArgs e)
        {

        }

        private void bAddCard_Click(object sender, EventArgs e)
        {
            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;
            int count = this.Deck.GetSizeofList();
            if (count == 0)
            {
                if (tQuestion.Text == "" || tAnswer.Text == "")
                    flag1 = false;
                else if (tQuestion.Text.Length > 100 || tAnswer.Text.Length > 1000)
                    flag3 = false;
            }
            for (int i = 0; i < count; i++)
            {
                if (tQuestion.Text == "" || tAnswer.Text == "")
                    flag1 = false;
                else if (tQuestion.Text == this.Deck.GetList(i).GetQuestion())
                    flag2 = false;
                else if (tQuestion.Text.Length > 100 || tAnswer.Text.Length > 1000)
                    flag3 = false;
            }
            if ((flag1) && (flag2) && (flag3))
            {
                DateTime T = DateTime.Now;
                db = new DataBase();
                db.InsertCard(Deck, T, tQuestion.Text, tAnswer.Text);
                Card c = new Card(tQuestion.Text, tAnswer.Text, T, 0);
                this.Deck.Add(c);
                tQuestion.Clear();
                tAnswer.Clear();
            }
            else
            {
                if (!flag1)
                    MessageBox.Show("Поля вопроса и ответа не могут быть пустыми.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag2)
                    MessageBox.Show("Не могут существовать карточки с одинаковыми вопросами", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag3)
                    MessageBox.Show("Вы превысили ограничение по символам\nОграничение для вопроса: 100 (у вас " 
                        + tQuestion.Text.Length + ")\nОграничение для ответа: 1000 (у вас " 
                        + tAnswer.Text.Length + ")", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}