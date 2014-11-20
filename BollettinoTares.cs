using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class BollettinoTares
	{
		// ATTRIBUTES
		[XmlAttribute("CodiceCatastale")]
		public string CodiceCatastale { get; set; }
		
		[XmlAttribute("TipoSoggetto")]
		public string TipoSoggetto { get; set; }
		
		[XmlAttribute("Intestatario")]
		public string Intestatario { get; set; }
		
		[XmlAttribute("CodiceFiscalePartitaIva")]
		public int CodiceFiscalePartitaIva  { get; set; }
		
		[XmlAttribute("DataNascita")]
		public int DataNascita  { get; set; }
		
		[XmlAttribute("ComuneNascita")]
		public string ComuneNascita { get; set; }
		
		[XmlAttribute("ProvinciaNascita")]
		public string ProvinciaNascita { get; set; }
		
		[XmlAttribute("Sesso")]
		public string Sesso { get; set; }
		
		// ELEMENTS
		[XmlElement("Versamento")]
		public Versamento Versamento { get; set; }
		
		[XmlElement("Maggiorazione")]
		public Maggiorazione Maggiorazione { get; set; }
		
		[XmlElement("Tributo")]
		public Tributo Tributo { get; set; }
		
		[XmlElement("Tariffa")]
		public Tariffa Tariffa { get; set; }
		
		// CONSTRUCTOR
		public BollettinoTares()
		{}
	}
}
