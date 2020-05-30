using System;
using System.Collections.Generic;

namespace SmartLearn
{
    public class CardList
    {
        public List<Card> Cards;
        int current;
        string Name;

        public int GetCurrent() { return this.current; }
        public void SetCurrent(int c) { this.current = c; }

        public string GetName() { return this.Name; }
        public void SetName(string s) { this.Name = s; }

        public Card GetList(int index) { return this.Cards[index]; }
        public void SetList(int index, Card c) { this.Cards[index] = c; }

        public int GetSizeofList() { return this.Cards.Count; }

        public CardList(string Name)
        {
            Cards = new List<Card>();
            current = 0;
            this.Name = Name;
        }

        public void Add(Card card)
        {
            Cards.Add(card);
        }

        public Card GetNext()
        {
            Card c;
            if (current == Cards.Count - 1)
            {
                current = 0;
                c = Cards[current];
            }
            else
            {
                current++;
                c = Cards[current];
            }
            return c;
        }

        public void Delete(int i)
        {
            Cards.RemoveAt(i);
        }

        public void Sorting()
        {
            Cards.Sort((x, y) => x.GetTime().CompareTo(y.GetTime()));
        }
    }
}
