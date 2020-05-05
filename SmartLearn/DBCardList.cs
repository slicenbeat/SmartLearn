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

    [Serializable]  
    class DBCardList
    {
        public Dictionary<string, CardList> db { get; set; }
        public DBCardList()
        {
            db = new Dictionary<string, CardList>();
        }

        public void Load(DBCardList db)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            db = (DBCardList)formatter.Deserialize(stream);
            stream.Close();
        }
        public void Save(DBCardList db)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, db);
            stream.Close();
        }

    }
}
