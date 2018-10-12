using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingApp
{
    enum TypeOfPayment
    {
        Debit,
        Credit,
        PayPal
    }
    class UserAccount
    {
        #region Properties
        /// <summary>
        /// User account properties
        /// </summary>

        public string UserAccountEmail { get; set; }
        public string UserAccountAddress { get; set; }
        public string UserAccountPayment { get; set; }
        
        #endregion


    }
    class GuestAccount
    {
        public string GuestAccountEmail { get; set; }
        public string GuestAccountAddress { get; set; }
        public string GuestAccountPayment { get; set; }
    }

    #region Methods

    #endregion
}
