using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Orwell.TSP;

namespace Orwell.TSP
{
    class TestReq
    {
        static void Main(string[] args)
        {
            /*
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();
            XmlSerializer deserializer = new XmlSerializer(ecr.GetType());
            TextReader reader = new StreamReader(@"C:/Users/danieleb/Documents/OrwellWorkspace/PROJECT_NEW_PSTA/EntityClassesAndXml/Richieste/testPrefilled.xml");

            object deserialized = deserializer.Deserialize(reader);
            ecr = (EasyChannelRichiesta)deserialized;
             */          

            Addebito addebito = new Addebito();
            addebito.TipoStrumento = "10";
            addebito.Value = "tryvalue";
            DatiCliente datiCliente = new DatiCliente();
            datiCliente.CAP = "00100";
            datiCliente.Citta = "Roma";
            datiCliente.Indirizzo = "Via del muro, 31";
            datiCliente.Nominativo = "Nominativo";
            datiCliente.Provincia = "Provincia di Roma";
            datiCliente.Value = "value";
            DatiBeneficiario datiBeneficiario = new DatiBeneficiario();
            datiBeneficiario.CausaleVersamento = "Causale Versamento";
            datiBeneficiario.DatiAnagrafici = "Nome Cognome Beneficiario";
            datiBeneficiario.Value = "beneficiario value";
            BollettinoBianco bollettinoBianco = new BollettinoBianco();
            bollettinoBianco.Addebito = addebito;
            bollettinoBianco.CodiceSIAAzienda = "1111111";
            bollettinoBianco.DatiBeneficiario = datiBeneficiario;
            bollettinoBianco.DatiCliente = datiCliente;
            bollettinoBianco.IdUtenza = "2222222";
            bollettinoBianco.ImportoBollettino = 121;
            bollettinoBianco.TipoDocumento = 321;
            Testata testata = new Testata();
            testata.Canale = "Canale";
            testata.Key = "Key";
            testata.NomeMessaggio = "Nome messaggio";
            testata.Timestamp = "333333";
            testata.Value = "Testata value";
            Verifica verifica = new Verifica();
            verifica.AbiMittente = "AbiMittente";
            verifica.AbiOrdinante = "AbiOrdinante";
            verifica.BollettinoBianco = bollettinoBianco;
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();
            ecr.Testata = testata;
            ecr.Verifica = verifica;

            ConvertTransactionRichiesta convertTransaction = new ConvertTransactionRichiesta();
            String result = convertTransaction.obj2Xml(ecr);
            
            
        }
    }
}
