using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntitiyBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        //public string ProductName { get; set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                //var stringHandler = new StringHandler();
                //return stringHandler.InsertSpace(_productName);
                //return StringHandler.InsertSpace(_productName);
                return _productName.InsertSpace();

            }
            set
            {
                _productName = value;
            }
        }

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";


        public override string ToString() => ProductName;


        ///<summary>
        ///Validates the product data.
        /// </summary>
        /// <return></return>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
