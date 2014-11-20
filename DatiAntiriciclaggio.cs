using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiAntiriciclaggio
	{
		// ATTRIBUTES
		[XmlAttribute("Nome")]
		public string Nome { get; set; }
		
		[XmlAttribute("Cognome")]
		public string Cognome { get; set; }
		
		[XmlAttribute("IdUnivocoPagatore")]
		public string IdUnivocoPagatore { get; set; }
		
		[XmlAttribute("DataNascita")]
		public int DataNascita  { get; set; }
		
		[XmlAttribute("LuogoNascita")]
		public string LuogoNascita { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public DatiAntiriciclaggio()
		{}
	}
}
