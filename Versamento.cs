using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class Versamento
	{
		// ATTRIBUTES
		[XmlAttribute("UnicaSoluzione")]
		public string UnicaSoluzione { get; set; }
		
		[XmlAttribute("RateNumero")]
		public int RateNumero  { get; set; }
		
		[XmlAttribute("NumeroRata")]
		public int NumeroRata  { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
        public void setUnicaSoluzione(bool bUnica)
        {
            if (bUnica)
            {
                UnicaSoluzione = "si";
            }
            else
            {
                UnicaSoluzione = "no";
            }
        }

		// CONSTRUCTOR
		public Versamento()
		{}
	}
}
