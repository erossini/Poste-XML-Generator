using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiCliente
	{
		// ATTRIBUTES
		[XmlAttribute("Nominativo")]
		public string Nominativo { get; set; }
		
		[XmlAttribute("Indirizzo")]
		public string Indirizzo { get; set; }
		
		[XmlAttribute("CAP")]
		public string CAP { get; set; }
		
		[XmlAttribute("Citta")]
		public string Citta { get; set; }
		
		[XmlAttribute("Provincia")]
		public string Provincia { get; set; }

        //TODO: This field seems never used
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public DatiCliente()
		{}
	}
}
