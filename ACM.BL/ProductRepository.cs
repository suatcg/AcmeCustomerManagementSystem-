﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        ///<summary>
        ///Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Product product = new Product(productId);
            // Code that retrieves the defined product;

            // Temporary hard-coded values to return
            // a populated customer
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object : {myObject.ToString()}");
            Console.WriteLine($"Product : {product.ToString()}");

            return product;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // Code that saves the passed in product

            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}