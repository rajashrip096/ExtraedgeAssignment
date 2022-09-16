using ExtraedgeAssignment.Models;
using ExtraedgeAssignment.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Services
{
    public class OrderPlaceService:IOrderPlaceService
    {
        private readonly IOrderPlaceRepository _repo;
        public OrderPlaceService(IOrderPlaceRepository repo)
        {
            _repo = repo;
        }
        public int AddOrderPlace(OrderPlace orderplace)
        {
            return _repo.AddOrderPlace(orderplace);
        }

        public int DeleteOrderPlace(int orderid)
        {
            return _repo.DeleteOrderPlace(orderid);
        }

        public IEnumerable<OrderPlace> GetAllOrderPlace()
        {
            return _repo.GetAllOrderPlace();
        }

        public OrderPlace GetOrderPlaceById(int orderid)
        {
            return _repo.GetOrderPlaceById(orderid);
        }

        public int ModifyOrderPlace(OrderPlace orderplace)
        {
            return _repo.ModifyOrderPlace(orderplace);
        }
    }
}
