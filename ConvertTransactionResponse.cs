using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Orwell
{
    public class ConvertTransactionResponse
    {
        public ConvertTransactionResponse() { }

        //public String obj2Xml(EasyChannel easyChannelRisposta)
        //{
        //    XmlWriterSettings settings = new XmlWriterSettings();
        //    settings.Encoding = Encoding.UTF8;
        //    settings.Indent = true;

        //    XmlSerializer xsSubmit = new XmlSerializer(easyChannelRisposta.GetType());
        //    StringWriter sww = new StringWriter();
        //    XmlWriter writer = XmlWriter.Create(sww,settings);
           
        //    xsSubmit.Serialize(writer, easyChannelRisposta);
        //    return sww.ToString(); // Your xml

        //}
        public EasyChannel xml2Object(XmlDocument xmlDoc)
        {
            EasyChannelRisposta ecr = null;
            XmlSerializer serializer = new XmlSerializer(typeof(EasyChannelRisposta));
            
            using (Stream s = GenerateStreamFromString(xmlDoc.InnerXml))
            {
                StreamReader reader = new StreamReader(s);
                ecr = (EasyChannelRisposta)serializer.Deserialize(reader);
                reader.Close();
            }

            return ecr;

        }

        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public String obj2Xml(EasyChannel easyChannel)
        {
            XmlSerializer serializer = new XmlSerializer(easyChannel.GetType());
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            // create a MemoryStream here, we are just working
            // exclusively in memory
            System.IO.Stream stream = new System.IO.MemoryStream();

            // The XmlTextWriter takes a stream and encoding
            // as one of its constructors
            System.Xml.XmlTextWriter xtWriter = new System.Xml.XmlTextWriter(stream, Encoding.UTF8);

            serializer.Serialize(xtWriter, easyChannel,ns);

            xtWriter.Flush();

            // go back to the beginning of the Stream to read its contents
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            // read back the contents of the stream and supply the encoding
            System.IO.StreamReader reader = new System.IO.StreamReader(stream, Encoding.UTF8);

            string result = reader.ReadToEnd();

            return result;
        }
    }
}
