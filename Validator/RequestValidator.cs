using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orwell.TSP;

namespace Orwell
{
    public class RequestValidator : Validator
    {
        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public RequestValidator() { }

        /// <summary>
        /// This method is used to check if Testata's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="testata"></param>
         
        private void validateTestata(Testata testata)
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
                throw new Exception(ResourceException.KeyTestata);
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
        

        /// <summary>
        /// This method is used to check if BollettinoBianco's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="bollettinoBianco"></param>
        private void validateBollettinoBianco(BollettinoBianco bollettinoBianco)
        {
            if (bollettinoBianco == null)
            {
                throw new Exception(ResourceException.BollettinoBianco);
            }
            if (bollettinoBianco.IdUtenza == null || bollettinoBianco.IdUtenza == "")
            {
                throw new Exception(ResourceException.IdUtenzaBollettinoBianco);
            }
            if (string.IsNullOrEmpty(bollettinoBianco.CodiceSIAAzienda))
            {
                throw new Exception(ResourceException.CodiceSIAAziendaBollettinoBianco);
            }
            if (string.IsNullOrEmpty(bollettinoBianco.TipoDocumento))
            {
                throw new Exception(ResourceException.TipoDocumentoBollettinoBianco);
            }
            if (bollettinoBianco.ImportoBollettino == null)
            {
                throw new Exception(ResourceException.ImportoBollettinoBollettinoBianco);
            }
        }

        /// <summary>
        /// This method is used to check if DatiBeneficiario's parameters are filled. This is not a semantic check.
        /// Attention! The attribute DatiBeneficiario is not checked because is optional (is used only in bollettini bianchi tares validation request)
        /// </summary>
        /// <param name="bollettinoPremarcato"></param>
        private void validateDatiBeneficiario(DatiBeneficiario datiBeneficiario)
        {
            if (datiBeneficiario == null)
            {
                throw new Exception(ResourceException.DatiBeneficiario);
            }

            if (datiBeneficiario.DatiAnagrafici == null || datiBeneficiario.DatiAnagrafici == "")
            {
                throw new Exception(ResourceException.DatiAnagraficiDatiBeneficiario);
            }
            if (datiBeneficiario.CausaleVersamento == null || datiBeneficiario.CausaleVersamento == "")
            {
                throw new Exception(ResourceException.CausaleVersamentoDatiBeneficiario);
            }            

        }

        /// <summary>
        /// This method is used to check if DatiCliente's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="bollettinoPremarcato"></param>
        private void validateDatiCliente(DatiCliente datiCliente)
        {
            if (datiCliente == null)
            {
                throw new Exception(ResourceException.DatiCliente);
            }
            if (datiCliente.Nominativo == null || datiCliente.Nominativo == "")
            {
                throw new Exception(ResourceException.NominativoDatiCliente);
            }
            if (datiCliente.Indirizzo == null || datiCliente.Indirizzo == "")
            {
                throw new Exception(ResourceException.IndirizzoDatiCliente);
            }
            if (datiCliente.CAP == null || datiCliente.CAP == "")
            {
                throw new Exception(ResourceException.CAPDatiCliente);
            }
            if (datiCliente.Citta == null || datiCliente.Citta == "")
            {
                throw new Exception(ResourceException.CittaDatiCliente);
            }
            if (datiCliente.Provincia == null || datiCliente.Provincia == "")
            {
                throw new Exception(ResourceException.ProvinciaDatiCliente);
            }
        }

        /// <summary>
        /// This method is used to check if Addebito's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="bollettinoPremarcato"></param>
        private void validateAddebito(Addebito addebito) {
            if (addebito == null)
            {
                throw new Exception(ResourceException.Addebito);
            }
            if (addebito.TipoStrumento == null || addebito.TipoStrumento== "")
            {
                throw new Exception(ResourceException.TipoStrumentoAddebito);
            }
        }

        /// <summary>
        /// This method is used to check if Conferma's parameters are filled. This is not a semantic check.
        /// </summary>
        /// <param name="conferma"></param>
        private void validateConferma (Conferma conferma){
            if (conferma == null) {
                throw new Exception(ResourceException.Conferma);
            }
            if (conferma.IdTransazione == null || conferma.IdTransazione == "") {
                throw new Exception(ResourceException.IdTransazioneConferma);
            }
        }

        private void validateConfermaBollettinoPremarcato(ConfermaBollettinoPremarcato confermaBollettinoPremarcato) {
            if (confermaBollettinoPremarcato == null)
            {
                throw new Exception(ResourceException.ConfermaBollettinoPremarcato);
            }
            if (confermaBollettinoPremarcato.IdUtenza == null || confermaBollettinoPremarcato.IdUtenza == "")
            {
                throw new Exception(ResourceException.IdUtenzaConfermaBollettinoPremarcato);
            }

            if (confermaBollettinoPremarcato.CommissioneSuOperazione == null)
            {
                throw new Exception(ResourceException.CommissioneSuOperazioneConfermaBollettinoPremarcato);
            }
            
        }

        private void validateConfermaBollettinoBianco(ConfermaBollettinoBianco confermaBollettinoBianco)
        {
            if (confermaBollettinoBianco == null)
            {
                throw new Exception(ResourceException.ConfermaBollettinoBianco);
            }
            if (confermaBollettinoBianco.IdUtenza == null || confermaBollettinoBianco.IdUtenza == "")
            {
                throw new Exception(ResourceException.IdUtenzaConfermaBollettinoBianco);
            }

            if (confermaBollettinoBianco.CommissioneSuOperazione == null)
            {
                throw new Exception(ResourceException.CommissioneSuOperazioneConfermaBollettinoBianco);
            }

        }

        /// <summary>
        /// This method is used to validate the Bollettino Premarcato Validation Request
        /// </summary>
        /// <param name="ecr"></param>

        public void validateBollettinoPremarcatoValidation(EasyChannelRichiesta ecr){
            validateTestata(ecr.Testata);
            validateVerifica(ecr.Verifica);
            validateBollettinoPremarcato(ecr.Verifica.BollettinoPremarcato);
            
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniPrefilledValidationRequest))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }
            /* TODO: We should have to be clear if DatiCliente is not null, should we need to check if It is correctly filled?
            if (ecr.Verifica.BollettinoPremarcato.DatiCliente != null)
            {
                validateDatiCliente(ecr.Verifica.BollettinoPremarcato.DatiCliente);
            }
            */
        }


        /// <summary>
        /// This method is used to validate the Bollettino Premarcato Confiramation Request
        /// </summary>
        /// <param name="ecr"></param>

        public void validateBollettinoPremarcatoConfirm(EasyChannelRichiesta ecr)
        {
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniPrefilledConfirm))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }

            validateConferma(ecr.Conferma);
            validateConfermaBollettinoPremarcato(ecr.Conferma.ConfermaBollettinoPremarcato);
        }


        public void validateBollettinoBiancoValidation(EasyChannelRichiesta ecr) {
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniBlankValidationRequest))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }
            validateVerifica(ecr.Verifica);
            validateBollettinoBianco(ecr.Verifica.BollettinoBianco);
            validateDatiBeneficiario(ecr.Verifica.BollettinoBianco.DatiBeneficiario);
            validateDatiCliente(ecr.Verifica.BollettinoBianco.DatiCliente);
            validateAddebito(ecr.Verifica.BollettinoBianco.Addebito);
        }

        public void validateBollettinoBiancoConfirm(EasyChannelRichiesta ecr)
        {
            validateTestata(ecr.Testata);
            if (ecr.Testata.NomeMessaggio != TypeOfTransaction.getService(TypeOfTransaction.TypeOfService.BollettiniBlankConfirm))
            {
                throw new Exception(ResourceException.NomeMessaggioTestataNotValid);
            }

            validateConferma(ecr.Conferma);
            validateConfermaBollettinoBianco(ecr.Conferma.ConfermaBollettinoBianco);
        }
    }
}
