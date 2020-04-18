using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace SmartLearn
{
    public partial class Test : MetroForm
    {
        List<string[]> QuestionsAnswers = new List<string[]>();
        int currentQuestion = 0;

        public Test()
        {
            InitializeComponent();
        }

        private void Run_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            if (ViewerAnswers.Visible)
                ViewerAnswers.Visible = false;
            else
                ViewerAnswers.Visible = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ViewerAnswers.Visible = false;

            if ((currentQuestion > QuestionsAnswers.Count)||(currentQuestion == QuestionsAnswers.Count))
            {
                currentQuestion = 0;
            }
            else
            {
                currentQuestion++;
                if ((currentQuestion > QuestionsAnswers.Count) || (currentQuestion == QuestionsAnswers.Count))
                {
                    currentQuestion = 0;
                }
            }
            ViewerQuestions.Text = QuestionsAnswers[currentQuestion][0] + "\r\n";
            ViewerAnswers.Text = QuestionsAnswers[currentQuestion][1] + "\r\n";


        }

        private void TxtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path; ;
            if (OpenCards.ShowDialog() == DialogResult.OK)
            {
                path = OpenCards.FileName;
                ShowNext.Enabled = true;
                ShowAnswer.Enabled = true;
                using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding("windows-1251")))//System.IO.File.ReadAllText(fileName путь к файлу )
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] questionAnswer = line.Split(';');
                        QuestionsAnswers.Add(questionAnswer);
                    }
                }
                ViewerQuestions.Text += QuestionsAnswers[0][0] + "\r\n";
                ViewerAnswers.Text += QuestionsAnswers[0][1] + "\r\n";
            }
            
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string path; ;
            if (SaveCards.ShowDialog() == DialogResult.OK)
            {
                path = SaveCards.FileName;
                string buff ="";
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.GetEncoding(1251)))
                {
                    for (int i = 0; i < QuestionsAnswers.Count; i++)
                    {
                        buff += QuestionsAnswers[i][0];
                        buff += " — ";
                        buff += QuestionsAnswers[i][1];
                        writer.WriteLine(buff);
                        buff = "";
                    }
                }

                
            }
        }

        private void ViewerQuestions_Click(object sender, EventArgs e)
        {

        }
    }
}
