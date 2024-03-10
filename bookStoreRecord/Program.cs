using System;
using System.ComponentModel.DataAnnotations;
namespace Record
{
        public record BookStore(int ID, string Title, string Author, double price);

    class Books 
    {
        static void displayBook(BookStore book)
        {
            Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.Author}, Price: ${book.price}");
        }
        public static void Main(string[] args)
        {
            BookStore book1 = new BookStore(1, "The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            BookStore book2 = new BookStore(2, "1984", "George Orwell", 9.99);
            BookStore book3 = new BookStore(3, "To Kill a Mockingbird", "Harper Lee", 8.99);
            displayBook(book1);
            displayBook(book2);
            displayBook(book3);


        }
    }
}