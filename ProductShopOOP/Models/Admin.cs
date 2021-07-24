using System;
using ProductShopOOP.Abstract;
using ProductShopOOP.Enums;
using ProductShopOOP.Interfaces;

namespace ProductShopOOP.Models
{
    class Admin : User, IAdmin
    {
        public Admin()
        {
            Role = Roles.Admin;
        }
        public override void AddToBasket(Product product)
        {
            throw new NotImplementedException();
        }

        public void CreateNewProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public override void FinishOrder()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromOrder()
        {
            throw new NotImplementedException();
        }
    }
}
