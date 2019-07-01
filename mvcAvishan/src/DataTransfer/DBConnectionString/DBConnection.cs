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
            SourceConnectionString = 0,
            TargetConnectionString = 1
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



    public class ConnectionStringCreator
    {
        
        public ConnectionStringSerialization FactoryMethod(string enConnectionType)
        {
            return new ConnectionStringSerialization(enConnectionType);
        }


    }
}
