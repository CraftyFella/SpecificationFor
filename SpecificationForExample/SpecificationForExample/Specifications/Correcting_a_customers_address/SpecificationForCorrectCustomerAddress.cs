using System;
using NSubstitute;
using NUnit.Framework;
using SpecificationForExample.Domain;
using SpecificationForExample.Infra;
using SpecificationForExample.Utils;

namespace SpecificationForExample.Specifications.Correcting_a_customers_address
{
    public abstract class SpecificationForCorrectCustomerAddress: SpecificationFor<Customer>
    {
        protected Customer.AddressDetails AddressDetails;
        protected ILogger Logger;

        protected override void SetupParameters()
        {
            AddressDetails = new Customer.AddressDetails { Postcode = "AB1 2CD" };
        }

        protected override void SetupDependencies()
        {
            Logger = Substitute.For<ILogger>();
        }

        protected override Customer CreateClassUnderTest()
        {
            return new Customer(Logger);
        }

        protected override void Because()
        {
            ClassUnderTest.CorrectCustomerAddress(AddressDetails);
        }
    }
}