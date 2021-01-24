using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntitiyBase, ILoggable
    {
        // Implicit default Constructor isn't automatically created when there are overloaded constructors defined
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public string CustomerType { get; set; }
        public string EmailAdress { get; set; }

        //Auto-implemented property ,if we no need logic getter and setter
        public string FirstName { get; set; }

        // We don't need a backing field cuz doesn't require holding any additional data LastName and FirstName take care of that
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrEmpty(FirstName))
                {
                    if(!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;

                }
                return fullName;
            }
        }

        public override string ToString() => FullName;

        public static int InstanceCount { get; set; }

        //Backing Field, hold the value 
        private string _lastName;

        // Property , get and set accessor 
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        //public string Log()
        //{
        //    var logString = CustomerId + ": " +
        //                    FullName + " " +
        //                    "Email: " + EmailAdress + " " +
        //                    "Status: " + EntityState.ToString();
        //    return logString;
        //}

        // Same above 
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAdress} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates teh customer data.
        /// </summary>
        /// <returns></returns>

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAdress)) isValid = false;

            return isValid;

        }

        

    }
}
