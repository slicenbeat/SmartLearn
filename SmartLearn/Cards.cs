using System;

namespace SmartLearn
{
    public class Cards
    {
        private string NameCardList { get; set; }
        private int number { get; set; }
        private int current { get; set; }
        public Cards()
        {
            NameCardList = "";
            number = 0;
            current = 0;
        }
        public Cards(string name, int n)
        {
            NameCardList = name;
            number = n;
        }
        public int nextID()
        {
            if (current == number)
            {
                current = 1;
                return 1;
            }
            else
            {
                current += 1;
                return current + 1;
            }
        }
        public int prevID()
        {
            if (current == 1)
            {
                current = number;
                return number;
            }
            else
            {
                current -= 1;
                return current - 1;
            }
        }
    }
}
