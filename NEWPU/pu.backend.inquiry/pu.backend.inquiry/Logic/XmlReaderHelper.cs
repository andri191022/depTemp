using System.Xml.Serialization;
using System.Xml;
using System.IO;
using pu.backend.inquiry.Models.GPHEmail;

namespace pu.backend.inquiry.Logic
{
    public class XmlReaderHelper
    {
        public XmlDocument ReadXml(string xmlString)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            return xmlDoc;
        }

        public XmlDocument ReadXmlFromFile(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            return xmlDoc;
        }

        public Document ReadXmlDocument(string xmlString)
        {
            XmlDocument xmlDoc = ReadXml(xmlString);
            XmlSerializer serializer = new XmlSerializer(typeof(Document));
            StringReader reader = new StringReader(xmlDoc.OuterXml);
            return (Document)serializer.Deserialize(reader);
        }

        public Document ReadXmlDocumentFromFile(string filePath)
        {
            XmlDocument xmlDoc = ReadXmlFromFile(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(Document));
            StringReader reader = new StringReader(xmlDoc.OuterXml);
            return (Document)serializer.Deserialize(reader);
        }
    }
}
