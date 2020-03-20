using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlTest
{
    using System.Xml;
    using System.IdentityModel.Tokens;
    class Program
    {
        static void Main(string[] args)
        {
            // Here we create some SAML assertion with ID and Issuer name. 
            SamlAssertion assertion = new SamlAssertion();
            assertion.AssertionId = "AssertionID";
            assertion.Issuer = "ISSUER";
            // Create some SAML subject. 
            SamlSubject samlSubject = new SamlSubject();
            samlSubject.Name = "My Subject";

            // 
            // Create one SAML attribute with few values. 
            SamlAttribute attr = new SamlAttribute();
            attr.Namespace = "http://daenet.eu/saml";
            attr.AttributeValues.Add("Some Value 1");
            //attr.AttributeValues.Add("Some Value 2");

            attr.Name = "My ATTR Value";

            // 
            // Now create the SAML statement containing one attribute and one subject. 
            SamlAttributeStatement samlAttributeStatement = new SamlAttributeStatement();
            samlAttributeStatement.Attributes.Add(attr);
            samlAttributeStatement.SamlSubject = samlSubject;

            // Append the statement to the SAML assertion. 
            assertion.Statements.Add(samlAttributeStatement);
        }
    }
}
