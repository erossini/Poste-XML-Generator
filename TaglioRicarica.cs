using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class TaglioRicarica
	{
		// ATTRIBUTES
		[XmlAttribute("Importo")]
		public string Importo  { get; set; }
		
		[XmlAttribute("Divisa")]
		public string Divisa { get; set; }
		
		[XmlAttribute("Commissioni")]
		public string Commissioni  { get; set; }
		
		[XmlAttribute("TotaleAddebito")]
		public string TotaleAddebito  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public TaglioRicarica()
		{}
	}
}
