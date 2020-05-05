using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SmartLearn
{

    class DBCardList
    {
        public Dictionary<string, CardList> db { get; set; }
        public DBCardList()
        {
            db = new Dictionary<string, CardList>();
        }

        public void Load(DBCardList db)
        {
            
        }
        public void Save(DBCardList db)
        {
            
        }

    }
}
