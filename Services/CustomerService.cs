using ExtraedgeAssignment.Models;
using ExtraedgeAssignment.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public int AddCustomer(Customer cust)
        {
            return _repo.AddCustomer(cust);
        }

        public int DeleteCustomer(int id)
        {
            return _repo.DeleteCustomer(id);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _repo.GetAllCustomer();
        }

        public Customer GetCustomerById(int id)
        {
            return _repo.GetCustomerById(id);
        }

        public int ModifyCustomer(Customer cust)
        {
            return _repo.ModifyCustomer(cust);
        }
    }
}
