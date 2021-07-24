using System;
using ProductShopOOP.Abstract;
using ProductShopOOP.Enums;
namespace ProductShopOOP.Models
{
    class Client: User
    {
        public Client()
        {
            Role = Roles.Client;
        }
        public override void AddToBasket(Product product)
        {
            throw new NotImplementedException();
        }
        public override void FinishOrder()
        {
            throw new NotImplementedException();
        }
    }
}
