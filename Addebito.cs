using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;

namespace Orwell
{
	public class Addebito
	{
		// ATTRIBUTES
		[XmlAttribute("TipoStrumento")]
		public string TipoStrumento  { get; set; }

        //TODO: This field seems never used
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Addebito()
		{
            TipoStrumento = "29";
        }
	}
}