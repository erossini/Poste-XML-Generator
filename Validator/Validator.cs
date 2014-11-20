using Orwell.TSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orwell
{
    public class  Validator
    {
        
        /// <summary>
        /// This method is used to check if Testata's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="testata"></param>

        public void validateTestata(Testata testata)
        {
            if (testata == null)
            {
                throw new Exception(ResourceException.Testata);
            }
            if (testata.NomeMessaggio == null || testata.NomeMessaggio == "")
            {
                throw new Exception(ResourceException.NomeMessaggioTestata);
            }
            if (testata.Timestamp == null || testata.Timestamp == "")
            {
                throw new Exception(ResourceException.TimestampTestata);
            }
            if (testata.Canale == null || testata.Canale == "")
            {
                throw new Exception(ResourceException.CanaleTestata);
            }
            if (testata.Key == null || testata.Key == "")
            {
                throw new Exception(ResourceException.NomeMessaggioTestata);
            }
            if (testata.Value == null || testata.Value == "")
            {
                throw new Exception(ResourceException.NomeMessaggioTestata);
            }
        }

        /// <summary>
        /// This method is used to check if BollettinoPremarcato's parameters are filled. This is not a semantic check.
        /// Attention! The attribute TipoBollettino is not checked because is optional (is used only in bollettini bianchi tares validation request)
        /// </summary>
        /// <param name="bollettinoPremarcato"></param>
        public void validateBollettinoPremarcato(BollettinoPremarcato bollettinoPremarcato)
        {
            if (bollettinoPremarcato == null)
            {
                throw new Exception(ResourceException.BollettinoPremarcato);
            }
            if (bollettinoPremarcato.IdUtenza == null || bollettinoPremarcato.IdUtenza == "")
            {
                throw new Exception(ResourceException.IdUtenzaBollettinoPremarcato);
            }
            if (bollettinoPremarcato.CodiceSIAAzienda == null || bollettinoPremarcato.CodiceSIAAzienda == "")
            {
                throw new Exception(ResourceException.CodiceSIAAziendaBollettinoPremarcato);
            }
            if (bollettinoPremarcato.TipoDocumento == null)
            {
                throw new Exception(ResourceException.TipoDocumentoBollettinoPremarcato);
            }
            if (bollettinoPremarcato.NumBollettino == null || bollettinoPremarcato.NumBollettino == "")
            {
                throw new Exception(ResourceException.NumBollettinoBollettinoPremarcato);
            }
            if (bollettinoPremarcato.ImportoBollettino == null)
            {
                throw new Exception(ResourceException.ImportoBollettinoBollettinoPremarcato);
            }

        }

     

    }
}
