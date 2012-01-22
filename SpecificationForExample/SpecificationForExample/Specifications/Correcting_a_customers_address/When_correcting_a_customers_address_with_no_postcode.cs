using System;
using FluentAssertions;
using NUnit.Framework;
using SpecificationForExample.Domain;

namespace SpecificationForExample.Specifications.Correcting_a_customers_address
{
    [TestFixture]
    public class When_correcting_a_customers_address_with_no_postcode : SpecificationForCorrectCustomerAddress
    {
        private Action action;

        protected override void SetupParameters()
        {
            AddressDetails = new Customer.AddressDetails();
        }

        protected override void Because()
        {
            action = () => ClassUnderTest.CorrectCustomerAddress(AddressDetails);
        }

        [Test]
        public void Then_unknown_postcode_exception_is_thrown()
        {
            action.ShouldThrow<UnknownPostcodeException>();
        }
    }
}