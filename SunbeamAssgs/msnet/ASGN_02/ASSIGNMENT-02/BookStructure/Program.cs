using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Book
{
    private string title;
    private bool outofstock;
    private string author;
    private int isbn;
    private char index;
    private double price;

    public Book(string title , bool outofstock , string author , int isbn , char index , double price)
    {
        this.title = title;
        this.outofstock = outofstock;
        this.author = author;
        this.isbn = isbn;
        this.index = index;
        this.price = price;

    }

    public string Title { get => title; set => title = value; }
    public bool Outofstock { get => outofstock; set => outofstock = value; }
    public string Author { get => author; set => author = value; }
    public int Isbn { get => isbn; set => isbn = value; }
    public char Index { get => index; set => index = value; }
    public double Price { get => price; set => price = value; }

    public void AcceptDetails()
    {
        Console.WriteLine("enter name of book");
        Title = Console.ReadLine();
        Console.WriteLine("enter out of stock status in true or false");
        Outofstock = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("enter  author's name of book");
        Author = Console.ReadLine();
        Console.WriteLine("enter Isbn status of book");
        Isbn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter index of book");
        Index = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("enter Price of book");
        Price = Convert.ToDouble(Console.ReadLine());
    } 

    public void PrintDetails()
    {
        Console.WriteLine("Title of book is " + Title);
        Console.WriteLine("Out of stock status of book is " + Outofstock);
        Console.WriteLine("Author of book is " + Author);
        Console.WriteLine("Isbn status of book is " + Isbn);
        Console.WriteLine("Index of book is " + Index);
        Console.WriteLine("Price of book is " + Price);
        Console.ReadLine();
    }
};

namespace BookStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();

            book1.AcceptDetails();




            Book book2 = new Book();

            book2.AcceptDetails();

            book1.PrintDetails();

            book2.PrintDetails();
        }
    }
}

