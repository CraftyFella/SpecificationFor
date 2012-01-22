using System;
using SpecificationForExample.Infra;

namespace SpecificationForExample.Domain
{
    public class Customer
    {
        private readonly ILogger logger;

        public Customer(ILogger logger)
        {
            this.logger = logger;
        }

        public class AddressDetails
        {
            public string Postcode { get; set; }
        }

        public void CorrectCustomerAddress(AddressDetails addressDetails)
        {
            if (string.IsNullOrWhiteSpace(addressDetails.Postcode))
                throw new UnknownPostcodeException();

            logger.Info("corrected!");
        }
    }

    
}
