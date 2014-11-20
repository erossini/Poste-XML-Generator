using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orwell.TSP.Request
{
    public class ForPostePay
    {
        public static string CancelRequest(string IDTransazione)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Annullo an = new Annullo();
            an.IdTransazione = IDTransazione;

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "AI61";

            ecr.Testata = testata;
            ecr.Annullo = an;

            return ecr.ToXML();
        }

        public static string ConfirmRequest(string TransazioneID, string NumeroCarta, string Importo)
        {
            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "PI61";

            Conferma cn = new Conferma();
            cn.IdTransazione = TransazioneID;

            ConfermaRicarica cr = new ConfermaRicarica();
            cr.IdUtenza = NumeroCarta;
            cr.CommissioneSuOperazione = "200";

            decimal tmp = Convert.ToDecimal(Importo);
            string tmpImporto = tmp.ToString().Replace(".", "");

            TaglioRicarica tr = new TaglioRicarica();
            tr.Importo = tmpImporto;
            tr.Divisa = "EUR";
            tr.Commissioni = "0";
            tr.TotaleAddebito = tmpImporto;
            cr.TaglioRicarica = tr;
            cn.ConfermaRicarica = cr;

            ecr.Testata = testata;
            ecr.Conferma = cn;

            return ecr.ToXML();
        }

        /// <summary>
        /// Create the XML string for a request for a bollettino prefilled
        /// </summary>
        /// <param name="ContoCorrentePostale"></param>
        /// <param name="Importo"></param>
        /// <param name="CodeLine5"></param>
        /// <returns></returns>
        public static string CreateFirstRequest(string NumeroCarta, string CodiceFiscaleTitolare, string CognomeNomeTitolare, 
                                                string CodiceFiscaleOrdinante, string CognomeNomeOrdinante)
        {
            string rtn = "";

            EasyChannelRichiesta ecr = new EasyChannelRichiesta();

            Testata testata = new Testata();
            testata.Canale = "WEB";
            testata.NomeMessaggio = "VI61";

            Verifica vr = new Verifica();
            vr.AbiMittente = "BJ25F";
            vr.AbiOrdinante = "BJ25F";

            RichiestaTagli rt = new RichiestaTagli();
            rt.IdUtenza = NumeroCarta;
            rt.CodiceSIAAzienda = "07601";
            vr.RichiestaTagli = rt;

            DatiAnagrafici da = new DatiAnagrafici();
            DatiTitolare dt = new DatiTitolare();
            dt.CodiceFiscale = CodiceFiscaleTitolare;
            dt.CognomeNome = CognomeNomeTitolare;
            DatiOrdinante dor = new DatiOrdinante();
            dor.CodiceFiscaleOrdinante = CodiceFiscaleOrdinante;
            dor.CognomeNomeOrdinante = CognomeNomeOrdinante;
            da.DatiOrdinante = dor;
            da.DatiTitolare = dt;
            vr.DatiAnagrafici = da;

            ecr.Testata = testata;
            ecr.Verifica = vr;

            rtn = ecr.ToXML();

            return rtn;
        }
    }
}