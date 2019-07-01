using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataTransfer
{

  
    public class GenericXMLSerializer<T> where T : new()
    {
        private string FileName = "";
        private string Directory = "";
       

        public GenericXMLSerializer(string FileName, string Directory = "Serialize")
        {
            this.Directory = Directory;
            this.FileName = FileName;
        }
         
        
        public bool Serialize(T obj)
        {
            string DirectoryPath = System.AppDomain.CurrentDomain.BaseDirectory+this.Directory;
            if (System.IO.Directory.Exists(DirectoryPath) == false) { System.IO.Directory.CreateDirectory(DirectoryPath); }
            StreamWriter SWriter = new System.IO.StreamWriter(DirectoryPath + "\\" + FileName + ".xml");
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(SWriter, obj);
            SWriter.Close();
            SWriter.Dispose();
            return true;

         
        }
        public T Deserialize()
        {
            T result = default(T);

            try
            {

                string DirectoryPath = System.AppDomain.CurrentDomain.BaseDirectory+this.Directory;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StreamReader SReader = new StreamReader(DirectoryPath + "\\" + this.FileName + ".xml");
                result = (T)serializer.Deserialize(SReader);
                SReader.Close();
                SReader.Dispose();
                               
            }
            catch
            {
                result = GetObject();
                Serialize(result);
            }
            return result;
        }

        protected T GetObject()
        {
            return new T();
        }

    }
}
