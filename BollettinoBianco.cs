using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class BollettinoBianco
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CodiceSIAAzienda")]
		public string CodiceSIAAzienda  { get; set; }
		
		[XmlAttribute("TipoDocumento")]
		public String TipoDocumento  { get; set; }
		
		[XmlAttribute("ImportoBollettino")]
		public string ImportoBollettino  { get; set; }
		
		[XmlElement("DatiCliente")]
		public DatiCliente DatiCliente { get; set; }
		
		[XmlElement("Addebito")]
		public Addebito Addebito { get; set; }

        // Tares
        // ELEMENTS
        [XmlElement("DatiBeneficiario")]
        public DatiBeneficiario DatiBeneficiario { get; set; }

        [XmlElement("BollettinoTares")]
        public BollettinoTares BollettinoTares { get; set; }

		// CONSTRUCTOR
		public BollettinoBianco()
		{}
	}
}
