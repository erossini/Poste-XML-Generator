using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class TaglioLibero
	{
		// ATTRIBUTES
		[XmlAttribute("MassimoRicaricabile")]
		public int MassimoRicaricabile  { get; set; }
		
		[XmlAttribute("Commissioni")]
		public int Commissioni  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public TaglioLibero()
		{}
	}
}
