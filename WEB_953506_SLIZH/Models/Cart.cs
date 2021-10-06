using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_SLIZH.Entities;

namespace WEB_953506_SLIZH.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }
        public Cart()
        {
            Items = new Dictionary<int, CartItem>();
        }
        public int Count
        {
            get{ return Items.Sum(item => item.Value.Quantity);}
        }
        public int Prices
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity * item.Value.Player.Cost);
            }
        }
        public virtual void AddToCart(Player player)
        {
            if (Items.ContainsKey(player.PlayerId))
            {
                Items[player.PlayerId].Quantity++;
            }
            else
                Items.Add(player.PlayerId, new CartItem
                {
                    Player = player,
                    Quantity = 1
                });
        }
        public virtual void RemoveFromCart(int id)
        {
            Items.Remove(id);
        }
        public virtual void ClearAll()
        {
            Items.Clear();
        }

    }

    public class CartItem
    {
        public Player Player { get; set; }
        public int Quantity { get; set; }
    }
}
