using System;

namespace SmartLearn
{
    class Card
    {
        public string Question { get; set; }
        public string Answer;
        public string[] Options { get; private set; }
        public int ID;

        public Card()
        {
            Options = new string[4];
            Question = "";
            Answer = "";
            ID = 0;
        }

        public Card(string ques, string ans)
        {
            Options = new string[4];
            Question = ques;
            Answer = ans;
            ID = 0;
        }

        public void AddOption(int index, string option)
        {
            if (index > Options.Length)
            {
                throw new IndexOutOfRangeException();
            }

            Options[index] = option;
        }

        public bool IsCorrect(string ans)
        {
            return ans == this.Answer;
        }
    }
}
