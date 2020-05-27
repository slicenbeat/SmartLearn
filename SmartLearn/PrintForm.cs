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
using System.Drawing.Printing;

namespace SmartLearn
{
    public partial class PrintForm : MetroForm
    {
        CardList Deck;
        string result;
        public PrintForm(CardList Deck)
        {
            InitializeComponent();
            this.Deck = Deck;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            result += Deck.GetName();
            for (int i = 0; i < this.Deck.GetSizeofList(); i++)
            {
                tPrintText.Text += "Вопрос: " +  Deck.GetList(i).GetQuestion() + Environment.NewLine + "Ответ: " 
                    +  Deck.GetList(i).GetAnswer() + Environment.NewLine + Environment.NewLine;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            //объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e) // обработчик событий
        {
            e.Graphics.DrawString(tPrintText.Text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        void TitlePageHandler(object sender, PrintPageEventArgs e) // обработчик событий
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void tPrintText_Click(object sender, EventArgs e)
        {

        }
    }
}
