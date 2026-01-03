using System.Configuration.Assemblies;
using OnlineFoodOrdering.Models;

namespace OnlineFoodOrdering.services;

public interface IFoodOrderingService
{
    void placeOrder(User Username,Item Item);
    
}