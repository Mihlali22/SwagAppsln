using SwagApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagApp.servicess.Interfaces
{
    public interface ILocalDatabase
    {
        List<CartItem> GetCartItems();
        void SavedCartItems(CartItem cartitem);

    }
}
