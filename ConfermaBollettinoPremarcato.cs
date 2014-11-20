using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	
	public class ConfermaBollettinoPremarcato
	{
		// ATTRIBUTES
		[XmlAttribute("IdUtenza")]
		public string IdUtenza  { get; set; }
		
		[XmlAttribute("CommissioneSuOperazione")]
		public int CommissioneSuOperazione  { get; set; }
		
        /// <summary>
        /// This field is not required for transaction with BollettinoPremarcato
        /// </summary>
		[XmlAttribute("DatiQuietanza")]
		public string DatiQuietanza { get; set; }

        // ELEMENTS 
        //TODO: This field there insn't in any xml file. We never use It
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public ConfermaBollettinoPremarcato()
		{}
	}
}
