using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class ATM
	{
		// ATTRIBUTES
		[XmlAttribute("CAB")]
		public int CAB  { get; set; }
		
		[XmlAttribute("NumeroSportello")]
		public int NumeroSportello  { get; set; }
		
		[XmlAttribute("NumeroOperazione")]
		public int NumeroOperazione  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public ATM()
		{}
	}
}
