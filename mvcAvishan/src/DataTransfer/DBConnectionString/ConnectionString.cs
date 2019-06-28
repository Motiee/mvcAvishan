using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    [Serializable]
    public class ConnectionString
    {

        public ConnectionString() {
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
}
