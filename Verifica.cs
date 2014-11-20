using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Verifica
	{
		// ATTRIBUTES
		[XmlAttribute("AbiOrdinante")]
		public string AbiOrdinante { get; set; }
		
		[XmlAttribute("AbiMittente")]
		public string AbiMittente { get; set; }

        // For bollettini
        // ELEMENTS
        [XmlElement("BollettinoPremarcato")]
        public BollettinoPremarcato BollettinoPremarcato { get; set; }

        // ELEMENTS
        [XmlElement("BollettinoBianco")]
        public BollettinoBianco BollettinoBianco { get; set; }

        // For PostePay
		// ELEMENTS
		[XmlElement("RichiestaTagli")]
		public RichiestaTagli RichiestaTagli { get; set; }
		
		[XmlElement("DatiAnagrafici")]
		public DatiAnagrafici DatiAnagrafici { get; set; }
		
		// CONSTRUCTOR
		public Verifica()
		{}
	}
}
