using System;
using ProductShopOOP.Enums;
using ProductShopOOP.Interfaces;


namespace ProductShopOOP.Abstract
{
    abstract class User: IClient
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string   Password { get; set; }

        public Roles Role { get; set; }
        public abstract void AddToBasket(Product product);
        public abstract void FinishOrder();

    }
}
