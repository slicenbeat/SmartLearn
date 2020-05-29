using System;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace SmartLearn
{
    public partial class EditCardList : MetroForm
    {
        private bool Delete;
        DataBase DB;
        CardList Deck;
        public EditCardList(CardList d)
        {
            InitializeComponent();
            this.Deck = d;
        }
        public EditCardList()
        {
            InitializeComponent();
        }


        //Предварительная заполнение cListQA списком карточек
        private void EditCardList_Load(object sender, EventArgs e)
        {
            cListQA.StyleManager = this.StyleManager;
            bAddCard.StyleManager = this.StyleManager;
            bEditCard.StyleManager = this.StyleManager;
            bDeleteCard.StyleManager = this.StyleManager;
            

            for (int i = 0; i < this.Deck.GetSizeofList(); i++)
            {
                cListQA.Items.Add(this.Deck.GetList(i).GetQuestion());
            }

            if (cListQA.Items.Count != 0)
            {
                cListQA.SelectedIndex = 0;
            }
        }
        //Обработка добавления карточки
        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddCard addcard = new AddCard(Deck);
            addcard.StyleManager = this.StyleManager;
            addcard.ShowDialog();
            cListQA.Items.Clear();
            EditCardList_Load(sender, e);
        }

        private void cListQA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Обработка удаления карточки
        private void bDeleteCard_Click(object sender, EventArgs e)
        {
            try
            {
                Delete = true;
                this.Deck.Delete(cListQA.SelectedIndex);
                cListQA.Items.Clear();
                EditCardList_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите карточку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Обработка закрытия окна
        private void EditCardList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Delete == true)
            {
                DB = new DataBase();
                DB.DeleteCard(Deck);
            }
        }

        //Обработка открытия карточки для редактирования
        private void ChangeCard_Click_1(object sender, EventArgs e)
        {

            int index = cListQA.SelectedIndex;
            if (index < 0)
                MessageBox.Show("Выберите карточку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                EditCard editcard = new EditCard(Deck, index);
                editcard.StyleManager = this.StyleManager;
                editcard.ShowDialog();
                cListQA.Items.Clear();
                EditCardList_Load(sender, e);
            }

        }
    }
}
