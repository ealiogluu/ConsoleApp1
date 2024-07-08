using Interkod.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.ViewModel
{
    class Order_
    {
        Order Order { get; set; } = new Order();
        public BookStore1 BookStore1_ { get; set; } = new BookStore1();
        MainViewModel MainViewModel { get; set; } = new MainViewModel();
        private void applyOrder()
        {
            Random rnd = new Random();
            var order = new Order();

            order.OrderItems = MainViewModel.Basket;
            order.OrderNumber = rnd.Next();
            System.Windows.MessageBox.Show($"Order {order.OrderNumber} created.");

        }

        // Add new book to order (works)
        public void AddItemToBasket(Book book, int quantity)
        {
            foreach (Book b in BookStore1_.Books)
            {
                if (book.Name == b.Name) MainViewModel.Basket.Add(new OrderItem(book, quantity, Order.OrderItems.Count));
            }
        }

        // Reduces book count (works)
        public void ReduceOrderItem(int id)
        {
            foreach (var book in Order.OrderItems)
            {
                if (book.Id == id) book.Quantity--;
                if (book.Quantity.Equals(0)) Order.OrderItems.Remove(book);
            }
        }

        //Remove book from order (works)
        public void RemoveOrderItem(int id)
        {
            foreach (var book in Order.OrderItems)
                if (book.Id.Equals(id)) Order.OrderItems.Remove(book);

        }


    }

}
