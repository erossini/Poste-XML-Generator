using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orwell.TSP
{
    public class TypeOfDocuments
    {
        public enum TypeOfDocument
        {
            // Bolletini Blank
            BollettinoPrefilled896 = 0,
            BollettinoPrefilled896Tares = 1,
            BollettinoPrefilled674 = 2,
            BollettinoBlank123 = 3,
            BollettinoBlank451 = 4,
            BollettinoBlank451Tares = 5
        }

        static Dictionary<TypeOfDocument, string> Bollettino = new Dictionary<TypeOfDocument, string>() {
            // Bolletini blank
            { TypeOfDocument.BollettinoPrefilled896, "896" },
            { TypeOfDocument.BollettinoPrefilled896Tares, "896" },
            { TypeOfDocument.BollettinoPrefilled674, "674" },
            { TypeOfDocument.BollettinoBlank123, "123" },
            { TypeOfDocument.BollettinoBlank451, "451" },
            { TypeOfDocument.BollettinoBlank451Tares, "451" }
        };

        public static string getBollettino(TypeOfDocument tob)
        {
            return Bollettino[tob];
        }
    }
}
