using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class RichiestaTagli
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CodiceSIAAzienda")]
		public string CodiceSIAAzienda  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public RichiestaTagli()
		{}
	}
}
