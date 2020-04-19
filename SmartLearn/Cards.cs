using System;

namespace SmartLearn
{
    public class Cards
    {
        private string NameCardList;
        private int Size;
        private int Number; 

        public string getName()
        {
            return this.NameCardList;
        }

        public int getSize()
        {
            return this.Size;
        }

        public int getNumber()
        {
            return this.Number;
        }

        public void setSize(int newSize)
        {
            this.Size = newSize;
        }

        public void setNumber(int newNumber)
        {
            this.Number = newNumber;
        }

        public Cards()
        {
            NameCardList = "";
            Size = 0;
            Number = 0;
        }

        public Cards(string name, int n)
        {
            NameCardList = name;
            Size = n;
        }

        public int nextID()
        {
            if (Number == Size)
            {
                Number = 1;
                return 1;
            }
            else
            {
                Number += 1;
                return Number + 1;
            }
        }

        public int prevID()
        {
            if (Number == 1)
            {
                Number = Size;
                return Size;
            }
            else
            {
                Number -= 1;
                return Number - 1;
            }
        }
    }
}
