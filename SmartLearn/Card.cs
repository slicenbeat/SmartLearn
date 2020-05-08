using System;

namespace SmartLearn
{
    public class Card
    {
        string Question;
        string Answer;
        int ID;

        public string GetQuestion() { return this.Question; }
        public void SetQuestion(string q) { this.Question = q; }

        public string GetAnswer() { return this.Answer; }
        public void SetAnswer(string a) { this.Answer = a; }

        public int GetID() { return this.ID; }
        public void SetID(int n) { this.ID = n; }

        public Card()
        {
            Question = "";
            Answer = "";
            ID = 0;
        }

        public Card(string ques, string ans)
        {
            Question = ques;
            Answer = ans;
            ID = 0;
        }

        public bool IsCorrect(string ans)
        {
            return ans == this.Answer;
        }
    }
}