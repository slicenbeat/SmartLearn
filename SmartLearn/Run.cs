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
    public partial class Run : MetroForm
    {
        List<string[]> questionsAnswers = new List<string[]>();
        int currentQuestion = 0;

        public Run()
        {
            InitializeComponent();
        }

        private void Run_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Visible)
                txtAnswer.Visible = false;
            else
                txtAnswer.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtAnswer.Visible = false;

            if ((currentQuestion > questionsAnswers.Count)||(currentQuestion == questionsAnswers.Count))
            {
                currentQuestion = 0;
            }
            else
            {
                currentQuestion++;
                if ((currentQuestion > questionsAnswers.Count) || (currentQuestion == questionsAnswers.Count))
                {
                    currentQuestion = 0;
                }
            }
            txtQuestion.Text = questionsAnswers[currentQuestion][0] + "\r\n";
            txtAnswer.Text = questionsAnswers[currentQuestion][1] + "\r\n";


        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "thequestions.txt"; ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                btnNext.Enabled = true;
                btnAnswer.Enabled = true;
                using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding("windows-1251")))//System.IO.File.ReadAllText(fileName путь к файлу )
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] questionAnswer = line.Split('—');
                        questionsAnswers.Add(questionAnswer);
                    }
                }

                txtQuestion.Text += questionsAnswers[0][0] + "\r\n";
                txtAnswer.Text += questionsAnswers[0][1] + "\r\n";
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
