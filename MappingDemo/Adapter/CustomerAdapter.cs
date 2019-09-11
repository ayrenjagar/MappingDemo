using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo.Adapter
{
    public class CustomerAdapter
    {

        public Model.Customer MapFromDTO(DTO.CustomerDTO customerDTO)
        {
            return new Model.Customer
            {
                Name = customerDTO.FirstName + " " + customerDTO.LastName
            };
        }

    }
}
