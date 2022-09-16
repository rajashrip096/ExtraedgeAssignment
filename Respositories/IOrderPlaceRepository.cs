using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Respositories
{
    public interface IOrderPlaceRepository
    {
        IEnumerable<OrderPlace> GetAllOrderPlace();
        OrderPlace GetOrderPlaceById(int orderid);
        int AddOrderPlace(OrderPlace orderplace);
        int ModifyOrderPlace(OrderPlace orderplace);
        int DeleteOrderPlace(int orderid);
    }
}
