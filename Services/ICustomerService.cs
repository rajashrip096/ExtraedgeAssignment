using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        int AddCustomer(Customer cust);
        int ModifyCustomer(Customer cust);
        int DeleteCustomer(int id);
    }
}
