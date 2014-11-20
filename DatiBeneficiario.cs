using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class DatiBeneficiario
	{
		// ATTRIBUTES
		[XmlAttribute("DatiAnagrafici")]
		public string DatiAnagrafici { get; set; }
		
		[XmlAttribute("CausaleVersamento")]
		public string CausaleVersamento { get; set; }
		
		// ELEMENTS
        //TODO: This field seems never used
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public DatiBeneficiario()
		{}
	}
}
