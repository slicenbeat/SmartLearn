using System;

namespace SmartLearn
{
    class Card
    {
        string Question;
        string Answer;
        //string[] Options;
        int ID;

        public string GetQuestion() { return this.Question; }
        public void SetQuestion(string q) { this.Question = q; }

        public string GetAnswer() { return this.Answer; }
        public void SetAnswer(string a) { this.Answer = a; }

        public int GetID() { return this.ID; }
        public void SetID(int n) { this.ID = n; }

        public Card()
        {
           // Options = new string[4];
            Question = "";
            Answer = "";
            ID = 0;
        }

        public Card(string ques, string ans)
        {
            //Options = new string[4];
            Question = ques;
            Answer = ans;
            ID = 0;
        }

        //public void AddOption(int index, string option)
        //{
        //    if (index > Options.Length)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }

        //    Options[index] = option;
        //}

        public bool IsCorrect(string ans)
        {
            return ans == this.Answer;
        }
    }
}