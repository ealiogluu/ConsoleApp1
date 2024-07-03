using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public Order(){}

        public Order(List<OrderItem> orderItem, int orderNumber, Customer customer)
        {
            OrderItems = orderItem;
            OrderNumber = orderNumber;
            Customer = customer;
        }

        //public void AddNewBookOrder(string bookName)
        //{
        //    foreach (var book in BookStore.Books)
        //        if (bookName == book.Name) BookStore.Orders.Add(book);

        //}
        //public void RemoveBookOrder(string bookName)
        //{
        //    foreach (var book in BookStore.Orders)
        //    {
        //        if (bookName == book.Name)
        //        {
        //            BookStore.Orders.Remove(book);
        //        }
        //    }
        //}

        //public void AddOrderItem(Book book, int quantity)
        //{
        //    foreach (Book b in BookStore.Books)
        //        if (book == b)  OrderItems.Add(new OrderItem(book, quantity, OrderItems.Count));
        //}

        //public void RemoveOrderItem(int id)
        //{
        //    foreach (var b in OrderItems)
        //    {
        //        if (b.Id == id) b.Quantity--;
        //    }
        //}
    }
}
