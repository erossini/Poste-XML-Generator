using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;
using Orwell.TSP;

namespace Orwell
{
	public class Testata
	{
		// ATTRIBUTES
		[XmlAttribute("NomeMessaggio")]
		public string NomeMessaggio { get; set; }
		
		[XmlAttribute("Timestamp")]
		public string Timestamp  { get; set; }
		
		[XmlAttribute("Canale")]
		public string Canale { get; set; }
		
		[XmlAttribute("Key")]
		public string Key { get; set; }
		
		// ELEMENTS
		[XmlText]
		public string Value { get; set; }
		
		// CONSTRUCTOR
		public Testata()
		{
            this.Canale = "WEB";
            this.Timestamp = SetItalianTimeForStandardDateFormat(DateTime.Now);
            this.Key = this.Timestamp + this.NomeMessaggio + this.Canale;
        }

        public Testata(TypeOfTransaction.TypeOfService tos)
        {
            this.Canale = "WEB";
            this.NomeMessaggio = TypeOfTransaction.getService(tos);
            this.Timestamp = SetItalianTimeForStandardDateFormat(DateTime.Now);
            this.Key = this.Timestamp + this.NomeMessaggio + this.Canale;
        }

        /// <summary>
        /// Return date in UTC format
        /// </summary>
        /// <param name="PrintDate"></param>
        /// <returns></returns>
        public string SetItalianTimeForStandardDateFormat(DateTime PrintDate)
        {
            TimeZoneInfo tst = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            PrintDate = TimeZoneInfo.ConvertTime(PrintDate, tst);

            return PrintDate.ToString("yyyyMMddHHmmssfff");
        }
    }
}
