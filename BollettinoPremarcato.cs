using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;
using Orwell.TSP;

namespace Orwell
{
	
	public class BollettinoPremarcato
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CodiceSIAAzienda")]
		public string CodiceSIAAzienda  { get; set; }

        [XmlAttribute("TipoDocumento")]
        public string TipoDocumento { get; set; }
		
		[XmlAttribute("NumBollettino")]
		public string NumBollettino  { get; set; }
		
		[XmlAttribute("ImportoBollettino")]
		public string ImportoBollettino  { get; set; }

        [XmlAttribute("TipoBollettino")]
        public string TipoBollettino { get; set; }
		
		// ELEMENTS
		[XmlElement("DatiCliente")]
		public DatiCliente DatiCliente { get; set; }
		
		[XmlElement("Addebito")]
		public Addebito Addebito { get; set; }

        // For Tares
        [XmlElement("DatiAntiriciclaggio")]
        public DatiAntiriciclaggio DatiAntiriciclaggio { get; set; }

        [XmlElement("BollettinoTares")]
        public BollettinoTares BollettinoTares { get; set; }

		// CONSTRUCTOR
		public BollettinoPremarcato()
		{}

        public BollettinoPremarcato(TypeOfDocuments.TypeOfDocument tod)
        {
            if (tod == TypeOfDocuments.TypeOfDocument.BollettinoPrefilled896Tares)
            {
                TipoBollettino = "26";
            }
            if (tod == TypeOfDocuments.TypeOfDocument.BollettinoBlank451Tares)
            {
                TipoBollettino = "25";
            }
        }
    }
}