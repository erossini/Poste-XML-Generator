using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orwell.TSP;

namespace Orwell
{
    public class ResponseValidator : Validator
    {
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public ResponseValidator() { }

        private void validateQuietanza(Quietanza quietanza)
        {
            if (quietanza == null)
            {
                throw new Exception(ResourceException.Quietanza);
            }
            if (quietanza.CodUffPostale == null)
            {
                throw new Exception(ResourceException.CodUffPostaleQuietanza);
            }
            if (quietanza.SezUffPostale == null)
            {
                throw new Exception(ResourceException.SezUffPostaleQuietanza);
            }
            if (String.IsNullOrEmpty(quietanza.UffVirtuale))
            {
                throw new Exception(ResourceException.UffVirtualeQuietanza);
            }
            if (String.IsNullOrEmpty(quietanza.CodStruPag))
            {
                throw new Exception(ResourceException.CodStruPagQuietanza);
            }
            if (quietanza.DataAccettazione == null)
            {
                throw new Exception(ResourceException.DataAccettazioneQuietanza);
            }
            if (quietanza.ProgIncasso == null)
            {
                throw new Exception(ResourceException.ProgIncassoQuietanza);
            }
            if (quietanza.ImportoBollettino == null)
            {
                throw new Exception(ResourceException.ImportoBollettinoQuietanza);
            }
            if (quietanza.CommissioniAzienda == null)
            {
                throw new Exception(ResourceException.CommissioniAziendaQuietanza);
            }
            if (quietanza.CommissioneAggiuntiva == null)
            {
                throw new Exception(ResourceException.CommissioneAggiuntivaQuietanza);
            }
            if (String.IsNullOrEmpty(quietanza.NumBollettino))
            {
                throw new Exception(ResourceException.NumBollettinoQuietanza);
            }
            
        }



        /// <summary>
        /// This method is used to check if Verifca's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="testata"></param>

        private void validateVerifica(Verifica verifica)
        {
            if (verifica == null)
            {
                throw new Exception(ResourceException.Verifica);
            }
            if (verifica.AbiMittente == null || verifica.AbiMittente== "")
            {
                throw new Exception(ResourceException.AbiMittenteVerifica);
            }

            if (verifica.AbiOrdinante == null || verifica.AbiOrdinante == "")
            {
                throw new Exception(ResourceException.AbiOrdinanteVerifica);
            }
        }

        private void validateDatiBollettinoPremarcato(DatiBollettinoPremarcato datiBollettinoPremarcato) {
            if (datiBollettinoPremarcato == null)
            {
                throw new Exception(ResourceException.DatiBollettinoPremarcato);
            }
            if (String.IsNullOrEmpty(datiBollettinoPremarcato.NumBollettino))
            {
                throw new Exception(ResourceException.NumBollettinoDatiBollettinoPremarcato);
            }

            if (datiBollettinoPremarcato.IntConto == null)
            {
                throw new Exception(ResourceException.IntContoDatiBollettinoPremarcato);
            }

            if (String.IsNullOrEmpty(datiBollettinoPremarcato.IdUtenza))
            {
                throw new Exception(ResourceException.IdUtenzaDatiBollettinoPremarcato);
            }

            if (datiBollettinoPremarcato.ImportoBollettino == null)
            {
                throw new Exception(ResourceException.ImportoBollettinoDatiBollettinoPremarcato);
            }
            if (datiBollettinoPremarcato.CommissioneAggiuntiva == null)
            {
                throw new Exception(ResourceException.CommissioneAggiuntivaDatiBollettinoPremarcato);
            }
            if (datiBollettinoPremarcato.CommissioniAzienda == null)
            {
                throw new Exception(ResourceException.CommissioniAziendaDatiBollettinoPremarcato);
            }
            if (datiBollettinoPremarcato.CommissioneSuOperazione == null)
            {
                throw new Exception(ResourceException.CommissioneSuOperazioneDatiBollettinoPremarcato);
            }
            if (datiBollettinoPremarcato.TotaleAddebito == null)
            {
                throw new Exception(ResourceException.TotaleAddebitoDatiBollettinoPremarcato);
            }

        }

        private void validateDatiBollettinoBianco(DatiBollettinoBianco datiBollettinoBianco)
        {
            if (datiBollettinoBianco == null)
            {
                throw new Exception(ResourceException.DatiBollettinoBianco);
            }

            if (datiBollettinoBianco.IntConto == null)
            {
                throw new Exception(ResourceException.IntContoDatiBollettinoBianco);
            }

            if (String.IsNullOrEmpty(datiBollettinoBianco.IdUtenza))
            {
                throw new Exception(ResourceException.IdUtenzaDatiBollettinoBianco);
            }

            if (datiBollettinoBianco.ImportoBollettino == null)
            {
                throw new Exception(ResourceException.ImportoBollettinoDatiBollettinoBianco);
            }
            if (datiBollettinoBianco.CommissioneAggiuntiva == null)
            {
                throw new Exception(ResourceException.CommissioneAggiuntivaDatiBollettinoBianco);
            }
            if (datiBollettinoBianco.CommissioniAzienda == null)
            {
                throw new Exception(ResourceException.CommissioniAziendaDatiBollettinoBianco);
            }
            if (datiBollettinoBianco.CommissioneSuOperazione == null)
            {
                throw new Exception(ResourceException.CommissioneSuOperazioneDatiBollettinoBianco);
            }
            if (datiBollettinoBianco.TotaleAddebito == null)
            {
                throw new Exception(ResourceException.TotaleAddebitoDatiBollettinoBianco);
            }

        }
       

        public void validateBollettinoPremarcatoValidationResponse (EasyChannelRisposta ecr)
        {
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniPrefilledValidationResponse))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }
            validateDatiBollettinoPremarcato(ecr.DatiBollettinoPremarcato);
        }

        public void validateBollettinoPremarcatoConfirmResponse(EasyChannelRisposta ecr)
        { 
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniPrefilledConfirmResponse))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }
            validateQuietanza(ecr.Quietanza);
        }

        public void validateBollettinoBiancoValidationResponse(EasyChannelRisposta ecr)
        {
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniBlankValidationResponse))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }
            validateDatiBollettinoBianco(ecr.DatiBollettinoBianco);
        }

        public void validateBollettinoBiancoConfirmResponse(EasyChannelRisposta ecr)
        {
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniBlankConfirmResponse))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }
            validateQuietanza(ecr.Quietanza);
        }
    }
}
