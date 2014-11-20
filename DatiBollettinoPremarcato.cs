using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiBollettinoPremarcato
	{
		// ATTRIBUTES
		[XmlAttribute("NumBollettino")]
		public string NumBollettino  { get; set; }
		
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("IntConto")]
		public string IntConto { get; set; }
		
		[XmlAttribute("ImportoBollettino")]
		public int ImportoBollettino  { get; set; }
		
		[XmlAttribute("CommissioniAzienda")]
		public int CommissioniAzienda  { get; set; }
		
		[XmlAttribute("CommissioneAggiuntiva")]
		public int CommissioneAggiuntiva  { get; set; }
		
		[XmlAttribute("CommissioneSuOperazione")]
		public int CommissioneSuOperazione  { get; set; }
		
		[XmlAttribute("TotaleAddebito")]
		public int TotaleAddebito  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public DatiBollettinoPremarcato()
		{}
	}
}
