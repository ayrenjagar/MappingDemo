using FluentAssertions;
using MappingDemo.Adapter;
using MappingDemo.DTO;
using MappingDemo.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemoTest
{
    [TestFixture]
    public class CustomerAdapterTest
    {

        private CustomerDTO customerDTO;
        private Customer customerCompare;
        private CustomerAdapter customerAdapter;

        [SetUp]
        public void GivenWeTransformACustomerDTO()
        {
            customerDTO = new CustomerDTO { FirstName = "Robert", LastName = "Zimmerman" };
            customerCompare = new Customer { Name = "Robert Zimmerman" };
            customerAdapter = new CustomerAdapter();
        }

        [Test]
        public void ShouldMapCustomer()
        {
            // Arrange


            // Act
            var result = customerAdapter.MapFromDTO(customerDTO);

            // Assert
            result.Should().BeEquivalentTo(customerCompare);
        }

    }
}
