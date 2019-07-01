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

        public string GetConnectionString()
        {
            if (UserName.Length == 0 || Password.Length == 0)
            {
                return String.Format("data source={0};database={1};", Server, DataBase);
            }
            else
            {
                return String.Format("data source={0};database={1};uid={2};pwd={3}", Server, DataBase, UserName, Password);
            }

        }
    }


    public  class ConnectionStringSerialization
    {
   
        private string DirectoryPath = "Settings";


        private string FileName;
        
        public ConnectionStringSerialization(string FileName)
        {
            this.FileName = FileName;
        }
        public  ConnectionString Get()

        {
            GenericXMLSerializer<ConnectionString> genericXMLSerializer = new GenericXMLSerializer<ConnectionString>(FileName,DirectoryPath);

            return genericXMLSerializer.Deserialize();
           
        }

        public  bool  Set(ConnectionString obj)
        {


            GenericXMLSerializer<ConnectionString> genericXMLSerializer = new GenericXMLSerializer<ConnectionString>(FileName,DirectoryPath);

             genericXMLSerializer.Serialize(obj);

          
            return true;
        }

    }



}
