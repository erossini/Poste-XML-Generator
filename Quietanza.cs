using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Quietanza
	{
		// ATTRIBUTES
		[XmlAttribute("CodUffPostale")]
		public string CodUffPostale  { get; set; }
		
		[XmlAttribute("SezUffPostale")]
		public string SezUffPostale  { get; set; }
		
		[XmlAttribute("UffVirtuale")]
		public string UffVirtuale { get; set; }
		
		[XmlAttribute("CodStruPag")]
		public string CodStruPag { get; set; }
		
		[XmlAttribute("DataAccettazione")]
		public int DataAccettazione  { get; set; }
		
		[XmlAttribute("ProgIncasso")]
		public string ProgIncasso  { get; set; }
		
		[XmlAttribute("ImportoBollettino")]
		public int ImportoBollettino  { get; set; }
		
		[XmlAttribute("CommissioniAzienda")]
		public int CommissioniAzienda  { get; set; }
		
		[XmlAttribute("CommissioneAggiuntiva")]
		public int CommissioneAggiuntiva  { get; set; }
		
		[XmlAttribute("NumBollettino")]
		public string NumBollettino  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Quietanza()
		{}
	}
}
