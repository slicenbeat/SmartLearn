using System;

namespace SmartLearn
{
    public class Card
    {
        string Question;
        string Answer;
        int ID;
        DateTime time;
        int level;

        public string GetQuestion() { return this.Question; }
        public void SetQuestion(string q) { this.Question = q; }

        public string GetAnswer() { return this.Answer; }
        public void SetAnswer(string a) { this.Answer = a; }

        public int GetID() { return this.ID; }
        public void SetID(int n) { this.ID = n; }

        public int GetLevel() { return this.level; }
        public void SetLevel(int l) { this.level = l; }

        public DateTime GetTime() { return this.time; }
        public void SetTime(DateTime t) { this.time = t; }

        public Card()
        {
            Question = "";
            Answer = "";
            ID = 0;
            level = 0;
        }

        public Card(string ques, string ans)
        {
            Question = ques;
            Answer = ans;
            ID = 0;
        }

        public Card(string ques, string ans, DateTime d, int l)
        {
            Question = ques;
            Answer = ans;
            ID = 0;
            this.level = l;
            this.time = d;
        }

        public bool IsCorrect(string ans)
        {
            return ans == this.Answer;
        }
        
    }
}