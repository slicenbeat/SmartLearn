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
        
        public void SetLevelUp(int l)
        {
            if (l != 8)
               this.level = l + 1;
            DateTime q = new DateTime();
            q = DateTime.Now;
            switch (level)
            {
                case 1:
                    q = q.AddMinutes(20);
                    break;
                case 2:
                    q = q.AddMinutes(60);
                    break;
                case 3:
                    q = q.AddHours(8);
                    break;
                case 4:
                    q = q.AddDays(1);
                    break;
                case 5:
                    q = q.AddDays(3);
                    break;
                case 6:
                    q = q.AddDays(7);
                    break;
                case 7:
                    q = q.AddDays(21);
                    break;
                case 8:
                    q = q.AddMonths(3);
                    break;

            }
            this.time = q;
        }

        public void SetLevelDown()
        {
            this.level = 0;
            this.time = DateTime.Now;
        }
    }
}