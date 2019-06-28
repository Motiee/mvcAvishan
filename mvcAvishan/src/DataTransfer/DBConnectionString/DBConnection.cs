using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
   public static class DBConnection
    {
        public enum enConnectionType
        {
            source = 0,
            Target = 1
        }


        public static ConnectionString GetConnectionString( enConnectionType value )
        {
            ConnectionStringCreator obj=new ConnectionStringCreator();

            return obj.FactoryMethod(value.ToString()).Get();

        
        }

        public static Boolean SetConnectionString(enConnectionType value,ConnectionString ConnectionString)
        {
            ConnectionStringCreator obj = new ConnectionStringCreator();

            return obj.FactoryMethod(value.ToString()).Set(ConnectionString);


        }
    }
}
