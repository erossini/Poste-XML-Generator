using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orwell.TSP.Request
{
    public class ForBollettinoBianco
    {
        public class Dettagli
        {
            private string _idUtenza;

            public string IdUtenza
            {
                get { return _idUtenza; }
                set { _idUtenza = value; }
            }

            private string _tipoBollettino;
            public string TipoBollettino
            {
                get { return _tipoBollettino; }
                set { _tipoBollettino = value; }
            }

            private string _importoBollettino;
            public string ImportoBollettino
            {
                get { return _importoBollettino; }
                set { _importoBollettino = value; }
            }

            private string _causaleVersamento;
            public string CausaleVersamento
            {
                get { return _causaleVersamento; }
                set { _causaleVersamento = value; }
            }

            private string _datiAnagrafici;
            public string DatiAnagrafici
            {
                get { return _datiAnagrafici; }
                set { _datiAnagrafici = value; }
            }

            private string _nominativo;
            public string Nominativo
            {
                get { return _nominativo; }
                set { _nominativo = value; }
            }

            private string _indirizzo;
            public string Indirizzo
            {
                get { return _indirizzo; }
                set { _indirizzo = value; }
            }

            private string _citta;
            public string Citta
            {
                get { return _citta; }
                set { _citta = value; }
            }

            private string _cap;
            public string CAP
            {
                get { return _cap; }
                set { _cap = value; }
            }

            private string _provincia;
            public string Provincia
            {
                get { return _provincia; }
                set { _provincia = value; }
            }
        }

        /// <summary>
        /// Create the XML string for cancelling a request for bollettino blank
        /// </summary>
        /// <param name="IDTransazione"></param>
        /// <returns></returns>
        public static string CancelRequest(string IDTransazione)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Annullo an = new Annullo();
            an.IdTransazione = IDTransazione;

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "AI9N";

            ecr.Testata = testata;
            ecr.Annullo = an;

            return ecr.ToXML();
        }

        /// <summary>
        /// Create the XML string for cancelling a request for bollettino blank
        /// </summary>
        /// <param name="IDTransazione"></param>
        /// <returns></returns>
        public static string ReversalRequest(string IDTransazione)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Annullo an = new Annullo();
            an.IdTransazione = IDTransazione;

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "SI9N";

            ecr.Testata = testata;
            ecr.Annullo = an;

            return ecr.ToXML();
        }

        /// <summary>
        /// Create the XML string for a request for a bollettino blank
        /// </summary>
        /// <param name="dettagliBollettino"></param>
        /// <returns></returns>
        public static string CreateFirstRequest(Dettagli dettagliBollettino)
        {
            string rtn = "";

            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "VI9N";

            BollettinoBianco bb = new BollettinoBianco();
            bb.CodiceSIAAzienda = "07601";
            bb.IdUtenza = dettagliBollettino.IdUtenza;
            bb.TipoDocumento = "123"; // dettagliBollettino.TipoBollettino;
            bb.ImportoBollettino = Convert.ToInt64((Convert.ToDecimal(dettagliBollettino.ImportoBollettino) * 100)).ToString();

            DatiBeneficiario db = new DatiBeneficiario();
            db.CausaleVersamento = dettagliBollettino.CausaleVersamento;
            db.DatiAnagrafici = dettagliBollettino.DatiAnagrafici;
            bb.DatiBeneficiario = db;

            DatiCliente dc = new DatiCliente();
            dc.Nominativo = dettagliBollettino.Nominativo;
            dc.Indirizzo = dettagliBollettino.Indirizzo;
            dc.CAP = dettagliBollettino.CAP;
            dc.Citta = dettagliBollettino.Citta;
            dc.Provincia = dettagliBollettino.Provincia;
            bb.DatiCliente = dc;

            Addebito ad = new Addebito();
            ad.TipoStrumento = "29";
            bb.Addebito = ad;

            Verifica verifica = new Verifica();
            verifica.AbiMittente = "BJ25F";
            verifica.AbiOrdinante = "BJ25F";
            verifica.BollettinoBianco = bb;

            ecr.Testata = testata;
            ecr.Verifica = verifica;

            rtn = ecr.ToXML();

            return rtn;
        }

        /// <summary>
        /// Create the XML string for a confirm for a bollettino blank
        /// </summary>
        /// <param name="ContoCorrente"></param>
        /// <param name="IDTransazione"></param>
        /// <returns></returns>
        public static string ConfirmRequest(string ContoCorrente, string IDTransazione)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "PI9N";

            ConfermaBollettinoBianco cbp = new ConfermaBollettinoBianco();
            cbp.IdUtenza = ContoCorrente;
            cbp.DatiQuietanza = "SI";

            Conferma cnf = new Conferma();
            cnf.IdTransazione = IDTransazione;
            cnf.ConfermaBollettinoBianco = cbp;

            ecr.Testata = testata;
            ecr.Conferma = cnf;

            return ecr.ToXML();
        }
    }
}
