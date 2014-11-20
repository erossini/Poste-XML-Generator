using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Tariffa
	{
		// ATTRIBUTES
		[XmlAttribute("RavvedimentoTariffa")]
		public string RavvedimentoTariffa { get; set; }
		
		[XmlAttribute("NumeroImmobiliTariffa")]
		public int NumeroImmobiliTariffa  { get; set; }
		
		[XmlAttribute("AnnoTariffa")]
		public int AnnoTariffa  { get; set; }
		
		[XmlAttribute("ImportoTariffa")]
		public int ImportoTariffa  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Tariffa()
		{}
	}
}
