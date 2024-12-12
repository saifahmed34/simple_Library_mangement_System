using Library_Management_System;
using Library_Management_System.Data;
using Library_Management_System.Models;
using System.Net;

var _context = new LibraryContext();

var member = new Member
{
    Name = "mohammed",
    Email = "saif@gmail.com",
    MembershipDate = DateTime.Now
};
_context.Add(member);
_context.SaveChanges();

var books = new Book
{
    Title = "Database",
    Author = "Mohamed",
    ISBN = "9780743273565",
    CopiesAvailable = 5,
    PublicationDate = new DateTime(1925, 4, 10)
};
_context.Add(books);
_context.SaveChanges();

var loan = new Loan
{
    BookId = books.BookId,
    MemberId = member.MemberId,
    LoanDate = DateTime.Now,
};
_context.Add(loan);
_context.SaveChanges();

Console.WriteLine("Data inserted successfully!");


