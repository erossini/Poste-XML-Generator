using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class TagliRicarica
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CommissioneSuOperazione")]
		public int CommissioneSuOperazione  { get; set; }
		
		[XmlAttribute("TipoCarta")]
		public string TipoCarta { get; set; }
		
		// ELEMENTS
		[XmlElement("TaglioLibero")]
		public TaglioLibero TaglioLibero { get; set; }
		
		// CONSTRUCTOR
		public TagliRicarica()
		{}
	}
}
