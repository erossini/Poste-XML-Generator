using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiAnagrafici
	{
		
		// ELEMENTS
		[XmlElement("DatiTitolare")]
		public DatiTitolare DatiTitolare { get; set; }
		
		[XmlElement("DatiOrdinante")]
		public DatiOrdinante DatiOrdinante { get; set; }
		
		// CONSTRUCTOR
		public DatiAnagrafici()
		{}
	}
}
