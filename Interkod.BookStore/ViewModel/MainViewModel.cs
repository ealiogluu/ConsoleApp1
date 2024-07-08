﻿using Interkod.BookStore.Models;
using System.Windows;
using System.Windows.Controls;

namespace Interkod.BookStore.ViewModel;

public class MainViewModel
{
    public Order Order { get; set; } = new Order();
    public List<OrderItem> Basket { get; set; }
    public BookStore1 BookStore { get; set; } = new BookStore1();

    public MainViewModel()
    {
        

        Book book1 = new("Suç", "Ahmet", 56,3.456, 67.90);
        Book book3 = new("yasak", "hamdi", 100,7.889, 110);
        Book book4 = new("Kezzap", "ayşe", 56,980, 23);

        BookStore.Books.Add(book1);
        BookStore.Books.Add(book3);
        BookStore.Books.Add(book4);

        Customer customer  = new Customer("ayse", 1, "ayse", "baris", 67583456);
        Customer customer2 = new Customer("burcu", 2, "burcu", "kurtkoy", 43756);
        BookStore.Customers.Add(customer);
        BookStore.Customers.Add(customer2); 
    }

    private void applyOrder()
    {
        Random rnd = new Random();
        var order = new Order();

        order.OrderItems = Basket;
        order.OrderNumber = rnd.Next();
        MessageBox.Show($"Order {order.OrderNumber} created.");

    }

    // Add new book to order (works)
    public void AddItemToBasket(Book book, int quantity)
    {
        foreach (Book b in BookStore.Books)
        {
            if (book.Name == b.Name) Basket.Add(new OrderItem(book, quantity, Order.OrderItems.Count));
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

    // EMPLOYEE
    //*********

    // Registration new book to sytem (works)
    public void AddNewBooKToSystem(string name, string author, int pageCount, double bookCount, double price)
    {
        var book = new Book();

        book.Name = name;
        book.Author = author;
        book.PageCount = pageCount;
        book.BookCount = bookCount;
        book.Price = price;
        
        BookStore.Books.Add(book);
        MessageBox.Show("Book registration successful.");
    }
    
    //Reduces Book count From System (works)
    public void ReducesBookCount(string bookName)
    {
        foreach (var book in BookStore.Books)
        {
            if (book.Name.Equals(bookName)) book.BookCount--;
            if (book.BookCount.Equals(0)) BookStore.Books.Remove(book);
        }
    }

    // Remove book from system (works)
    public void RemoveBookFromSystem(string bookName)
    {
        foreach (var book in BookStore.Books)
            if (book.Name.Equals(bookName)) BookStore.Books.Remove(book);
    }
}