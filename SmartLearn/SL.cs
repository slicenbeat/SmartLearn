using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLearn
{
    class SL
    {
        public CardList Cards { get; set; }
        public string Name { get; set; }

        public SL(string Name)
        {
            Cards = new CardList(Name);
        }

        public void Save(string Name)
        {

        }

        public void Delete(string Name)
        {

        }

        public void Load(string Name)
        {

        }
    }
}


/*using System;

namespace Quizzer
{
    class Quiz
    {
        public CardList Cards { get; set; }
        public string Title { get; set; }
        public string Author;
        public DateTime LastModified { get; private set; }
        public int ID;

        public Quiz()
        {
            ID = 0;
            LastModified = DateTime.Now;
            Cards = new CardList();
        }

        public Quiz(CardList list)
        {
            ID = 0;
            LastModified = DateTime.Now;
            Cards = list;
        }

        public void Save()
        {
            QuizLoaderDB.Save(this);
        }

        public void Delete()
        {
            QuizLoaderDB.Delete(this);
        }
    }
}
*/