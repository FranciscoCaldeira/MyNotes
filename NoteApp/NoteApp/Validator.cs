using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // for email validation

namespace NoteApp
{
    class Validator
    {
        #region "regex" for email input in login
        /// <summary>
        /// // email validation in https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            if (new EmailAddressAttribute().IsValid(email))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
