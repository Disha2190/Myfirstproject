using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CrudeOperation
{
    class Author
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
    class Book
    {
        int bookid;
        string bookname;
        int price;
        Author a;
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

        public Author A
        {
            get { return a; }
            set { a = value; }
        }


    }
    class CrudeOperations
    {
        public Book[] bk = new Book[20];
        public int booksize;
        public void Insert() //Insertion of book
        {
            Console.WriteLine("Enter how many books details you want to enter");
            int NoOfBook = int.Parse(Console.ReadLine());
            int bookid, price, authorid;
            string bookname, authorname;
            if (NoOfBook < bk.Length)
            {
                for (int i = 0; i < NoOfBook; i++)
                {
                    bk[i] = new Book();
                    bool ispresent = false;
                    Console.WriteLine("Enter Book id: ");
                    bookid = int.Parse(Console.ReadLine());
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (bk[k].BookId.Equals(bookid))
                        {
                            Console.WriteLine("Id already exists");
                            ispresent = true;
                            NoOfBook++;
                            bk[i] = new Book();
                            break;
                        }
                    }
                    try
                    {
                        if (ispresent == false)
                        {
                            Console.WriteLine("Enter Book name: ");
                            bookname = Console.ReadLine();
                            Console.WriteLine("Enter book price: ");
                            price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author id: ");
                            authorid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author name: ");
                            authorname = Console.ReadLine();
                            bk[i].BookId = bookid;
                            bk[i].BookName = bookname;
                            bk[i].Price = price;
                            bk[i].A = new Author();
                            bk[i].A.AuthorId = authorid;
                            bk[i].A.Authorname = authorname;
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Please enter in proper format");
                        NoOfBook++;
                    }
                }
              //  booksize = NoOfBook;
            }
            else
            {
                Console.WriteLine("Please enter number of books again your books size is larger");
            }
        }
        public void GetBooksDetails(int bkid) //Display details of Book
        {
            bool ispresent = false;
            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i] != null)   //Check null value
                {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        Console.WriteLine("Book Details:\n Book Id:" + bk[i].BookId + "\nBook Name: " + bk[i].BookName + "\nBook Price: " + bk[i].Price + "\nAuthor Id: " + bk[i].A.AuthorId + "\nAuthor Name:" + bk[i].A.Authorname);
                        ispresent = true;
                        break;
                    }
                }
            }
            if (ispresent == false)
            {
                Console.WriteLine("Book Details not found");
                Console.WriteLine("Book id doese not present please enter right book id");
            }
        }
        public void UpdateBookDetails(int bkid) //Update Details of book
        {
            bool ispresent = false;
            
            for (int i = 0; i < bk.Length; i++)
            {
                if (bk[i] != null)  //Check null value
                {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        Console.WriteLine("Enter Book new price: ");
                        int newprice = int.Parse(Console.ReadLine());
                        bk[i].Price = newprice;
                        ispresent = true;
                        break;
                    }
                }
            }
            if (ispresent == false)
            {
                Console.WriteLine("Book Id not found please enter proper Id");
            }
            else
            {
                Console.WriteLine("Book updated");
            }
        }
        public void DeleteBookDetails(int bkid) //Delete Details of book
        {
            bool ispresent = false;
            for (int i = 0; i < bk.Length; i++)
            {
                 if(bk[i]!=null)  //Check null value
                 {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        bk[i].BookId = 0;
                        bk[i].BookName = "";
                        bk[i].Price = 0;
                        bk[i].A.AuthorId = 0;
                        bk[i].A.Authorname = "";
                        ispresent = true;
                        break;
                    }
                 }
            }    
            if(ispresent==true)
            {
                Console.WriteLine("Book Details Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Book Details not found");
            }
        }
    }
    class BookDetails
    {
        static void Main(string[] args)
        {
            CrudeOperations op = new CrudeOperations();
            bool stop = false;
            do
            {
                int n;
                Console.WriteLine("\t\t\t\t\t\tWelcome");
                Console.WriteLine("\t\t\t\t\tTo Book Management");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t1.Insert\n\t\t\t\t\t2.Display\n\t\t\t\t\t3.Update\n\t\t\t\t\t4.Delete\n\t\t\t\t\t5.Exit\n\t\t\t\t\tEnter option: ");
                n = int.Parse(Console.ReadLine());
                switch(n)
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
