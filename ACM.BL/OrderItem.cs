using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        ///<summary>
        ///Retrieve one product.
        /// </summary>
        public OrderItem Retrieve(int productId)
        {
            // Code that retrieve the defined product

            return new OrderItem();
        }

        ///<summary>
        ///Saves the urrent product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined prodcut

            return true;
        }

        ///<summary>
        ///Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
