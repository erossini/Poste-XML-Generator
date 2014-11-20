using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Conferma
	{
		// ATTRIBUTES
		[XmlAttribute("IdTransazione")]
		public string IdTransazione  { get; set; }
		
		// ELEMENTS
		[XmlElement("ConfermaBollettinoPremarcato")]
		public ConfermaBollettinoPremarcato ConfermaBollettinoPremarcato { get; set; }

        // ELEMENTS
        [XmlElement("ConfermaBollettinoBianco")]
        public ConfermaBollettinoBianco ConfermaBollettinoBianco { get; set; }

        // For PostePay
        // ELEMENTS
        [XmlElement("ConfermaRicarica")]
        public ConfermaRicarica ConfermaRicarica { get; set; }

		// CONSTRUCTOR
		public Conferma()
		{}
	}
}
