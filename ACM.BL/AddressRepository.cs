using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        ///<summary>
        ///Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // pass in the requested id
            var address = new Address(addressId);

            // Code that retrieves the defined address;

            // Temporary hard-coded values to return
            // a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshow row";
                address.City = "Hobbitton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = 144;

            }
            return address;
        }

        public IEnumerable<Address>  RetrieveByCustomerId(int custormerId)
        {
            // Code that retrieves the defined address
            // for the customer.

            // Temporary hard-coded values to return
            // a populated address
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshow row",
                City = "Hobbitton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = 144
            };
            addressList.Add(address);


            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                StreetLine2 = "Bagshow row",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = 146
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // Code that saves the passed in address

            return true;
        }
    }
}
