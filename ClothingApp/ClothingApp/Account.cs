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
        enum TypeOfClothing
    {
        Shirt,
        Sweather,
        Pants
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

    class Clothing
    {
        #region Properties
        /// <summary>
        /// Clothing Item Properties
        /// </summary>

        public string ClothingType { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Quantity { get; set; }

        #endregion
    }

    #region Methods

    #endregion
}
