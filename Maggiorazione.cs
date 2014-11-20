using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Maggiorazione
	{
		// ATTRIBUTES
		[XmlAttribute("RavvedimentoMaggiorazione")]
		public string RavvedimentoMaggiorazione { get; set; }
		
		[XmlAttribute("NumeroImmobiliMaggiorazione")]
		public int NumeroImmobiliMaggiorazione  { get; set; }
		
		[XmlAttribute("AnnoMaggiorazione")]
		public int AnnoMaggiorazione  { get; set; }
		
		[XmlAttribute("ImportoMaggiorazione")]
		public int ImportoMaggiorazione  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Maggiorazione()
		{}
	}
}
