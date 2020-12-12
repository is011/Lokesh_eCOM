using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_HW_eCOM.Models
{
	public class LS_HW_eCOMpingCart
	{
		private readonly ApplicationDbContext _context;

		public LS_HW_eCOMpingCart(ApplicationDbContext context)
		{
			_context = context;
		}

		public string Id { get; set; }
		public IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }

		public static LS_HW_eCOMpingCart GetCart(IServiceProvider services)
		{
			ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
			var context = services.GetService<ApplicationDbContext>();
			string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

			session.SetString("CartId", cartId);
			return new LS_HW_eCOMpingCart(context) { Id = cartId };
		}

		public bool AddToCart(Food food, int amount)
		{
			if(food.InStock == 0 || amount == 0)
			{
				return false;
			}
			
			var ShoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
				s => s.Food.Id == food.Id && s.LS_HW_eCOMpingCartId == Id);
            var isValidAmount = true;
			if (ShoppingCartItem == null)
			{
                if (amount > food.InStock)
                {
                    isValidAmount = false;
                }
                ShoppingCartItem = new ShoppingCartItem
                {
                    LS_HW_eCOMpingCartId = Id,
                    Food = food,
                    Amount = Math.Min(food.InStock, amount)
				};
				_context.ShoppingCartItems.Add(ShoppingCartItem);
			}
			else
			{
                if(food.InStock - ShoppingCartItem.Amount - amount >= 0)
                {
                    ShoppingCartItem.Amount +=  amount;
                }
                else
                {
					ShoppingCartItem.Amount += (food.InStock - ShoppingCartItem.Amount);
                    isValidAmount = false;
                }
            }


			_context.SaveChanges();
            return isValidAmount;
		}

		public int RemoveFromCart(Food food)
		{
			var ShoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
				s => s.Food.Id == food.Id && s.LS_HW_eCOMpingCartId == Id);
			int localAmount = 0;
			if (ShoppingCartItem != null)
			{
				if (ShoppingCartItem.Amount > 1)
				{
					ShoppingCartItem.Amount--;
					localAmount = ShoppingCartItem.Amount;
				}
				else
				{
					_context.ShoppingCartItems.Remove(ShoppingCartItem);
				}
			}

			_context.SaveChanges();
			return localAmount;
		}

		public IEnumerable<ShoppingCartItem> GetShoppingCartItems()
		{
			return ShoppingCartItems ??
				   (ShoppingCartItems = _context.ShoppingCartItems.Where(c => c.LS_HW_eCOMpingCartId == Id)
					   .Include(s => s.Food));
		}

		public void ClearCart()
		{
			var cartItems = _context
				.ShoppingCartItems
				.Where(cart => cart.LS_HW_eCOMpingCartId == Id);

			_context.ShoppingCartItems.RemoveRange(cartItems);
			_context.SaveChanges();
		}

		public decimal GetLS_HW_eCOMpingCartTotal()
		{
			return _context.ShoppingCartItems.Where(c => c.LS_HW_eCOMpingCartId == Id)
				.Select(c => c.Food.Price * c.Amount).Sum();
		}

	}
}
