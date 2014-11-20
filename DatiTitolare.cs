using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiTitolare
	{
		// ATTRIBUTES
		[XmlAttribute("CodiceFiscale")]
		public string CodiceFiscale { get; set; }
		
		[XmlAttribute("CognomeNome")]
		public string CognomeNome { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public DatiTitolare()
		{}
	}
}
