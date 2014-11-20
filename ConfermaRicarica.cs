using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class ConfermaRicarica
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CommissioneSuOperazione")]
		public string CommissioneSuOperazione  { get; set; }
		
		// ELEMENTS
		[XmlElement("TaglioRicarica")]
		public TaglioRicarica TaglioRicarica { get; set; }
		
		// CONSTRUCTOR
		public ConfermaRicarica()
		{}
	}
}
