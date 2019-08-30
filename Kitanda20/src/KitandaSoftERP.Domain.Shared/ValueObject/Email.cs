using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Shared.ValueObject
{
    public class Email
    {
        public string AddressEmail { get; set; }


        public bool IsValidEmailAddress(string pEmail)
        {
            if (!string.IsNullOrEmpty(pEmail))
            {
                return CheckEmailValidation(pEmail);
            }
            else
            {
                return true;
            }
        }

        private bool CheckEmailValidation(string pEmail)
        {
            bool isValid = false;
            int indexArr = pEmail.IndexOf("@");
            if (indexArr > 0)
            {
                int indexDot = pEmail.LastIndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < pEmail.Length)
                    {
                        string indexDot2 = pEmail.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            isValid = true;
                        }
                    }
                }
            }

            return isValid;
        }
    }

    
}
