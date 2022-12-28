using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myfirstproject.CrudeOperation
{
    class Author1
    {
        int authorid;
        string authorname;
        public int AuthorId
        {
            get { return authorid; }
            set { authorid = value; }
        }
        public string Authorname
        {
            get { return authorname; }
            set { authorname = value; }
        }
    }
    class Book1
    {
        int bookid;
        string bookname;
        int price;
        Author1 a;
        public int BookId
        {
            get { return bookid; }
            set { bookid = value; }
        }
        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Author1 A
        {
            get { return a; }
            set { a = value; }
        }
    }
    class CrudeOperations1
    {
        public ArrayList al = new ArrayList();
        public void Insert()
        {
            Console.WriteLine("Enter how many books details you want to enter");
            int NoOfBook = int.Parse(Console.ReadLine());
            int bookid, price, authorid;
            string bookname, authorname;
            for (int i=0;i<NoOfBook;i++)
            {
                bool ispresent = false;
                Console.WriteLine("Enter the book id:");
                bookid = int.Parse(Console.ReadLine());
                foreach(Book1 bk in al)
                {
                    if(bk.BookId.Equals(bookid))
                    {
                        Console.WriteLine("Book Id already exists");
                        ispresent = true;
                        NoOfBook++;
                        break;
                    }
                }
                if(!ispresent)
                {
                    Book1 bk = new Book1();
                    Console.WriteLine("Enter Book name: ");
                    bookname = Console.ReadLine();
                    Console.WriteLine("Enter book price: ");
                    price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter author id: ");
                    authorid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter author name: ");
                    authorname = Console.ReadLine();
                    bk.BookId = bookid;
                    bk.BookName = bookname;
                    bk.Price = price;
                    bk.A = new Author1();
                    bk.A.AuthorId= authorid;
                    bk.A.Authorname = authorname;
                    al.Add(bk);
                }
            }
        }
        public void GetBooksDetails(int bkid)
        {
            bool ispresent = false;
            if (al.Count != 0)
            {
                foreach (Book1 bk in al)
                {
                    if (bk.BookId.Equals(bkid))
                    {
                        Console.WriteLine("Book Details:\n Book Id:" + bk.BookId + "\nBook Name: " + bk.BookName + "\nBook Price: " + bk.Price + "\nAuthor Id: " + bk.A.AuthorId + "\nAuthor Name:" + bk.A.Authorname);
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    Console.WriteLine("Book Details not found");
                    Console.WriteLine("Book id doese not present please enter right book id");
                }
            }
            else
            {
                Console.WriteLine("Current BookList is Empty");
                Console.WriteLine("Please insert data first");
            }
        }
        public void UpdateBookDetails(int bkid)
        {
            if (al.Count != 0)
            {
                bool isupdated = false;

                foreach (Book1 bk in al)
                {
                    if (bk.BookId.Equals(bkid))
                    {
                        Console.WriteLine("Enter Book new price: ");
                        int newprice = int.Parse(Console.ReadLine());
                        bk.Price = newprice;
                        isupdated = true;
                        break;
                    }
                }
                if (isupdated == false)
                {
                    Console.WriteLine("Book Id not found please enter proper Id");
                }
                else
                {
                    Console.WriteLine("Book updated");
                }
            }
            else
            {
                Console.WriteLine("Current BookList is Empty");
                Console.WriteLine("Please insert data first");
            }
           
        }
        public void DeleteBookDetails(int bkid)
        {
            
            if (al.Count != 0)
            {
                bool ispresent = false;
                foreach (Book1 bk in al)
                {
                    if (bk.BookId.Equals(bkid))
                    {
                        al.Remove(bk);
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == true)
                {
                    Console.WriteLine("Book Details Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Book Details not found");
                }
            }
            else
            {
                Console.WriteLine("Current BookList is Empty");
                Console.WriteLine("Please insert data first");
            }

        }
    }
    class BookDetailsArrList
    {
        static void Main(string[] args)
        {
            CrudeOperations1 op = new CrudeOperations1();
            bool stop = false;
            do
            {
                int n;
                Console.WriteLine("\t\t\t\t\t\tWelcome");
                Console.WriteLine("\t\t\t\t\tTo Book Management");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t1.Insert\n\t\t\t\t\t2.Display\n\t\t\t\t\t3.Update\n\t\t\t\t\t4.Delete\n\t\t\t\t\t5.Exit\n\t\t\t\t\tEnter option: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        op.Insert();
                        break;
                    case 2:
                        Console.WriteLine("Enter Book's id whose detailed to be viewed:");
                        op.GetBooksDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter Book's id whose detailed to be updated:");
                        op.UpdateBookDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter Book's id whose detailed to be deleted:");
                        op.DeleteBookDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            } while (!stop);
        }
    }
}
