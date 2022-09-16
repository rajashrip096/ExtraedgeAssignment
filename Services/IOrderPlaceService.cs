
using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Services
{
    public interface IOrderPlaceService
    {
        IEnumerable<OrderPlace> GetAllOrderPlace();
        OrderPlace GetOrderPlaceById(int id);
        int AddOrderPlace(OrderPlace orderplace);
        int ModifyOrderPlace(OrderPlace orderplace);
        int DeleteOrderPlace(int id);
    }
}
