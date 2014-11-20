using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orwell.TSP
{
    public class TypeOfTransaction
    {
        public enum TypeOfService
        {
            // Bolletini Blank
            BollettiniBlankValidationRequest = 0,
            BollettiniBlankValidationResponse = 1,
            BollettiniBlankConfirm = 2,
            BollettiniBlankConfirmResponse = 3,
            BollettiniBlankCancel = 4,
            BollettiniBlankCancelResponse = 5,
            BollettiniBlankCancelReversal = 6,
            BollettiniBlankCancelReversalResponse = 7,

            // Bollettini prefilled
            BollettiniPrefilledValidationRequest = 9,
            BollettiniPrefilledValidationResponse = 10,
            BollettiniPrefilledConfirm = 11,
            BollettiniPrefilledConfirmResponse = 12,
            BollettiniPrefilledCancel = 13,
            BollettiniPrefilledCancelResponse = 14,
            BollettiniPrefilledCancelReversal = 15,
            BollettiniPrefilledCancelReversalResponse = 16,

            // PostePay
            PostePayValidationRequest = 17,
            PostePayValidationResponse = 18,
            PostePayConfirm = 19,
            PostePayConfirmResponse = 20,
            PostePayCancel = 21,
            PostePayCancelResponse = 22
        }

        static Dictionary<TypeOfService, string> Service = new Dictionary<TypeOfService, string>() {
            // Bolletini blank
            { TypeOfService.BollettiniBlankValidationRequest, "VI9N" },
            { TypeOfService.BollettiniBlankValidationResponse, "VO9N" },
            { TypeOfService.BollettiniBlankConfirm, "PI9N" },
            { TypeOfService.BollettiniBlankConfirmResponse, "PO9N" },
            { TypeOfService.BollettiniBlankCancel, "AI9N" },
            { TypeOfService.BollettiniBlankCancelResponse, "AOxx" },
            { TypeOfService.BollettiniBlankCancelReversal, "SIXX" },
            { TypeOfService.BollettiniBlankCancelReversalResponse, "SOXX" },

            // Bollettini prefilled
            { TypeOfService.BollettiniPrefilledValidationRequest, "VI9O" },
            { TypeOfService.BollettiniPrefilledValidationResponse, "VO9O" },
            { TypeOfService.BollettiniPrefilledConfirm, "PI9O" },
            { TypeOfService.BollettiniPrefilledConfirmResponse, "PO9O" },
            { TypeOfService.BollettiniPrefilledCancel, "AI9O" },
            { TypeOfService.BollettiniPrefilledCancelResponse, "AOxx" },
            { TypeOfService.BollettiniPrefilledCancelReversal, "SIXX" },
            { TypeOfService.BollettiniPrefilledCancelReversalResponse, "SOXX" },

            // PostePay
            { TypeOfService.PostePayValidationRequest, "VI61" },
            { TypeOfService.PostePayValidationResponse, "VO61" },
            { TypeOfService.PostePayConfirm, "PI61" },
            { TypeOfService.PostePayConfirmResponse, "PO61" },
            { TypeOfService.PostePayCancel, "AI61" },
            { TypeOfService.PostePayCancelResponse, "AOxx" }
        };

        public static string getService(TypeOfService tos)
        {
            return Service[tos];
        }
    }
}
