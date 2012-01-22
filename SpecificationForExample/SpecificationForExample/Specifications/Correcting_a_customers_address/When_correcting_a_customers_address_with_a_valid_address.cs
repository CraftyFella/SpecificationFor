using System;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using SpecificationForExample.Domain;

namespace SpecificationForExample.Specifications.Correcting_a_customers_address
{
    [TestFixture]
    public class When_correcting_a_customers_address_with_a_valid_address : SpecificationForCorrectCustomerAddress
    {
        [Test]
        public void Then_correction_is_logged()
        {
            Logger.Received().Info(Arg.Any<string>());
        }
    }
}