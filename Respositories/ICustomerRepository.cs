using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Respositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        int AddCustomer(Customer cust);
        int ModifyCustomer(Customer cust);
        int DeleteCustomer(int id);
    }
}
