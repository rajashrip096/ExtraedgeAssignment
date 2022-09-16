using ExtraedgeAssignment.Entities;
using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ExtraedgeAssignment.Entities.ApplicationDbContext;

namespace ExtraedgeAssignment.Respositories
{
    public class CustomerRepository:ICustomerRepository
    {
        ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddCustomer(Customer cust)
        {
            _context.Customer.Add(cust);
            int res = _context.SaveChanges();
            return res;
        }

        public int DeleteCustomer(int id)
        {
            var cust = _context.Customer.Where(x => x.Id == id).SingleOrDefault();
            if (cust != null)
            {
                _context.Customer.Remove(cust);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _context.Customer.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            var cust = _context.Customer.Where(x => x.Id == id).SingleOrDefault();
            return cust;
        }

        public int ModifyCustomer(Customer cust)
        {
            var cu = _context.Customer.Where(x => x.Id == cust.Id).SingleOrDefault();
            if (cu != null)
            {
                cu.Name = cust.Name;
                cu.Email = cust.Email;
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
