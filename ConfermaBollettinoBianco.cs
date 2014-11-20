using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class ConfermaBollettinoBianco
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CommissioneSuOperazione")]
		public int CommissioneSuOperazione  { get; set; }
		
		[XmlAttribute("DatiQuietanza")]
		public string DatiQuietanza { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public ConfermaBollettinoBianco()
		{}
	}
}
