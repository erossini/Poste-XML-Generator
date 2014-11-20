using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orwell.TSP.Request
{
    public class ForBollettinoPremarcato
    {
        /// <summary>
        /// Create the XML string for cancelling a request for bollettino prefilled
        /// </summary>
        /// <param name="IDTransazione"></param>
        /// <returns></returns>
        public static string CancelRequest(string IDTransazione)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Annullo an = new Annullo();
            an.IdTransazione = IDTransazione;

            Testata testata = new Testata(TypeOfTransaction.TypeOfService.BollettiniPrefilledCancel);
            testata.Canale = "WEB";
            testata.NomeMessaggio = "AI9O";

            ecr.Testata = testata;
            ecr.Annullo = an;

            return ecr.ToXML();
        }

        /// <summary>
        /// Create the XML string for a request for a bollettino prefilled
        /// </summary>
        /// <param name="ContoCorrentePostale"></param>
        /// <param name="Importo"></param>
        /// <param name="CodeLine5"></param>
        /// <returns></returns>
        public static string CreateFirstRequest(string ContoCorrentePostale, string Importo, string CodeLine5, string TipoBollettino)
        {
            string rtn = "";

            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "VI9O";

            BollettinoPremarcato bp = new BollettinoPremarcato();
            bp.CodiceSIAAzienda = "07601";
            bp.IdUtenza = ContoCorrentePostale;
            bp.TipoDocumento = TipoBollettino.Replace("TD", "");
            bp.ImportoBollettino = Convert.ToInt64(Convert.ToDecimal(Importo) * 100).ToString();
            bp.NumBollettino = CodeLine5;

            Addebito ad = new Addebito();
            ad.TipoStrumento = "29";
            bp.Addebito = ad;

            Verifica verifica = new Verifica();
            verifica.AbiMittente = "BJ25F";
            verifica.AbiOrdinante = "BJ25F";
            verifica.BollettinoPremarcato = bp;

            ecr.Testata = testata;
            ecr.Verifica = verifica;

            rtn = ecr.ToXML();

            return rtn;
        }

        /// <summary>
        /// Create the XML string for a confirm for a bollettino prefilled
        /// </summary>
        /// <param name="ContoCorrente"></param>
        /// <param name="IDTransazione"></param>
        /// <returns></returns>
        public static string ConfirmRequest(string ContoCorrente, string IDTransazione)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "PI9O";

            ConfermaBollettinoPremarcato cbp = new ConfermaBollettinoPremarcato();
            cbp.IdUtenza = ContoCorrente;
            cbp.DatiQuietanza = "SI";

            Conferma cnf = new Conferma();
            cnf.IdTransazione = IDTransazione;
            cnf.ConfermaBollettinoPremarcato = cbp;

            ecr.Testata = testata;
            ecr.Conferma = cnf;

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
            testata.NomeMessaggio = "SI9O";

            ecr.Testata = testata;
            ecr.Annullo = an;

            return ecr.ToXML();
        }
    }
}
