using System.Xml.Schema;
using System.Xml;
using System.Xml.Linq;

namespace pu.backend.inquiry.Helper
{
    public class XmlUtil
    {
        public static string doValidateXML()
        {
            string xsdFilePath = "path/to/your/schema.xsd";
            string nameSpace = "urn:iso:std:ido:20022:tech:xsd:pain.001.001.03";
            string xmlDocument = @"
        <note>
            <to>Tove</to>
            <from>Jani</from>
            <heading>Reminder</heading>
            <body>Don't forget me this weekend!</body>
        </note>";
            // Load the schema from the XSD file

            string errMsg = string.Empty;
            try
            {
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add(nameSpace, xsdFilePath);

                XDocument doc = XDocument.Load(xmlDocument);

                doc.Validate(schema, (o, e) =>
                {
                    errMsg += e.Message + " ";
                });
                
            }
            catch (Exception ex) 
            {
                errMsg = ex.Message;    
            }


            return errMsg;
        }
    }
}
