using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DataTransfer
{

    [Serializable]
    public class ConnectionString
    {

        public ConnectionString()
        {
            this.Server = "";
            this.DataBase = "";
            this.UserName = "";
            this.Password = "";
        }
        public ConnectionString(string Server, string DataBase, string UserName, string Password)
        {
            this.Server = Server;
            this.DataBase = DataBase;
            this.UserName = UserName;
            this.Password = Password;
        }
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }


    public  class ConnectionStringSerialization
    {
   
        private string DirectoryPath = System.AppDomain.CurrentDomain.BaseDirectory + "Settings";


        private string FileName;
        
        public ConnectionStringSerialization(string FileName)
        {
            this.FileName = FileName;
        }
        public  ConnectionString Get()

        {
            ConnectionString obj = new ConnectionString();
            XmlSerializer serializer = new XmlSerializer(typeof(ConnectionString));

            try
            {
                StreamReader SReader = new StreamReader(DirectoryPath + "\\"+this.FileName+".xml");
                obj = (ConnectionString)serializer.Deserialize(SReader);
                SReader.Close();
                SReader.Dispose();
            }
            catch
            {
                Set(obj);
            }

            return obj;
        }

        public  bool  Set(ConnectionString obj)
        {
            if (System.IO.Directory.Exists(DirectoryPath)==false) { System.IO.Directory.CreateDirectory(DirectoryPath); }
            StreamWriter SWriter = new System.IO.StreamWriter(DirectoryPath + "\\" + this.FileName+".xml");
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(SWriter, obj);
            SWriter.Close();
            SWriter.Dispose();
            return true;
        }

    }



}
