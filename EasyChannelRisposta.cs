using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class EasyChannelRisposta : EasyChannel
	{
		// ATTRIBUTES
		[XmlAttribute("Versione")]
		public decimal Versione  { get; set; }
		
		[XmlAttribute("IdTransazione")]
		public string IdTransazione  { get; set; }
		
		[XmlAttribute("Esito")]
		public string Esito { get; set; }
		
		// ELEMENTS
		[XmlElement("Testata")]
		public Testata Testata { get; set; }
		
		[XmlElement("Quietanza")]
		public Quietanza Quietanza { get; set; }

        [XmlElement("DatiBollettinoBianco")]
        public DatiBollettinoBianco DatiBollettinoBianco { get; set; }

        [XmlElement("DatiBollettinoPremarcato")]
        public DatiBollettinoPremarcato DatiBollettinoPremarcato { get; set; }

        /// <summary>
        /// Used by Postapay validation response
        /// </summary>
        [XmlElement("TagliRicarica")]
        public TagliRicarica TagliRicarica { get; set; }

        [XmlElement("MessaggioErrore")]
        public MessaggioErrore MessaggioErrore { get; set; }

		// CONSTRUCTOR
		public EasyChannelRisposta()
		{}
	}
}
