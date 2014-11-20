using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Tributo
	{
		// ATTRIBUTES
		[XmlAttribute("RavvedimentoTributo")]
		public string RavvedimentoTributo { get; set; }
		
		[XmlAttribute("NumeroImmobiliTributo")]
		public int NumeroImmobiliTributo  { get; set; }
		
		[XmlAttribute("AnnoTributo")]
		public int AnnoTributo  { get; set; }
		
		[XmlAttribute("ImportoTributo")]
		public int ImportoTributo  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Tributo()
		{}
	}
}
