using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Orwell
{
	
	public class EasyChannelRichiesta : EasyChannel
	{
        // CONSTRUCTOR
        public EasyChannelRichiesta(){ }

		// ATTRIBUTES
		[XmlAttribute("Versione")]
		public string Versione  { get; set; }
		
		// ELEMENTS
		[XmlElement("Testata")]
		public Testata Testata { get; set; }
		
        // For bolletini
		[XmlElement("Conferma")]
		public Conferma Conferma { get; set; }

        // For PostePay
        [XmlElement("Verifica")]
        public Verifica Verifica { get; set; }

        // For all
        [XmlElement("Annullo")]
        public Annullo Annullo { get; set; }

        public string ToXML()
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(EasyChannelRichiesta));
            StringWriter sww = new StringWriter();

            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Encoding = System.Text.Encoding.UTF8;

            XmlWriter writer = XmlWriter.Create(sww, xws);
            xsSubmit.Serialize(writer, this);
            return sww.ToString(); // Your xml
        }
	}
}
