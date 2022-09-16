using ExtraedgeAssignment.Entities;
using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Respositories
{
    public class OrderPlaceRepository:IOrderPlaceRepository
    {
        ApplicationDbContext _context;
        public OrderPlaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddOrderPlace(OrderPlace orderplace)
        {
            _context.OrderPlace.Add(orderplace);
            int res = _context.SaveChanges();
            return res;
        }

        public int DeleteOrderPlace(int id)
        {
            var orderplace = _context.OrderPlace.Where(x => x.OrderId == id).SingleOrDefault();
            if (orderplace != null)
            {
                _context.OrderPlace.Remove(orderplace);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<OrderPlace> GetAllOrderPlace()
        {
            return _context.OrderPlace.ToList();
        }

        public OrderPlace GetOrderPlaceById(int id)
        {
            var orderplace = _context.OrderPlace.Where(x => x.OrderId == id).SingleOrDefault();
            return orderplace;
        }

        public int ModifyOrderPlace(OrderPlace  orderplace)
        {
            var op = _context.OrderPlace.Where(x => x.OrderId == orderplace.OrderId).SingleOrDefault();
            if (op != null)
            {
                op.Name = orderplace.Name;
                op.Email = orderplace.Email;
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
