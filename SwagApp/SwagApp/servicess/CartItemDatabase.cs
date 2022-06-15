using SQLite;
using SwagApp.Models;
using SwagApp.servicess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagApp.servicess
{
    
    public class CartItemDatabase : ILocalDatabase
    {
        private SQLiteConnection _database;

        public CartItemDatabase ()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "cartitem.db";

            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<CartItem>();
        }

        public List<CartItem> GetCartItems()
        {
            return _database.Table<CartItem>().OrderByDescending(x => x.DateTime).ToList();
        }

        public void SavedCartItems(CartItem cartitem)
        {
            _database.Insert(cartitem);
        }
    }
}
