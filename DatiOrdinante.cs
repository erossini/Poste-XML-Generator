using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiOrdinante
	{
		// ATTRIBUTES
		[XmlAttribute("CodiceFiscaleOrdinante")]
		public string CodiceFiscaleOrdinante { get; set; }
		
		[XmlAttribute("CognomeNomeOrdinante")]
		public string CognomeNomeOrdinante { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public DatiOrdinante()
		{}
	}
}
