using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Book
    {
        int book_id;
        string book_name;
        int price;
        int count = 0;
        Book[] book = new Book[100];
        public Book()
        {

        }
        public Book(int book_id, string book_name, int price)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.price = price;

        }
        public void InsertBook()
        {
            Console.WriteLine("Enter How many book you want to insert");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter Book Id");

                int bid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter book name");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter Price");
                int price = Convert.ToInt32(Console.ReadLine());
                book[count] = new Book(bid, bname, price);
                count++;

            }
        }
        public void ShowBook()
        {
            for (int i = 0; i < count; i++)
            {
                if (book[i] != null)
                {
                    Console.WriteLine(book[i]);
                }
            }

        }
        public override string ToString()
        {
            return $"{book_id}\n{book_name}\n{price}";
        }
        public void SearchBook()
        {
            Book b = new Book();
            Console.WriteLine("Enter Search ID");
            int searchId = Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;
            for (int i = 0; i <count; i++ )
            {
                if(book[i] != null )
                {
                    if (book[i].book_id == searchId)
                    {
                        isPresent = true;
                        b= book[i];
                       
                    }
                }
            }
            if(isPresent)
            {
                Console.WriteLine(b);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Book does not exist");
            }

        }
        public void UpdateBook()
        {
            Console.WriteLine("Enter Book Id for update");
            int book_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Price");
            int price = Convert.ToInt32(Console.ReadLine());
            bool isUpdate = false;
            for(int i = 0; i <count; i++)
            {
                if(book[i] != null )
                {
                    if (book[i].book_id == book_id)
                    {
                        book[i].price = price;
                        isUpdate = true;
                    }
                }
            }
            if(isUpdate)
            {
                Console.WriteLine("Update success");
                Console.ReadLine();
            }

        }
        public void DeleteBook()
        {
            Console.WriteLine("Enter Id for Delete");
            int book_id = Convert.ToInt32(Console.ReadLine());
            bool isDelete = false;
            for(int i = 0; i <count; i++)
            {
                if (book[i] != null )
                {
                    if (book[i].book_id ==  book_id)
                    {
                        book[i] = book[i + 1];
                        isDelete= true;
                    }
                }
                count--;
                book[count] = null;
            }
            Console.WriteLine("Book is Deleted");
        }
        static void Main(string[] args)
        {
            Book b = new Book();
            //b.InsertBook();
            //b.ShowBook();
            //b.SearchBook();
            //b.UpdateBook();
            //b.ShowBook();
            int option=0;
            do
            {
                Console.WriteLine("Select Option");
                Console.WriteLine("1.Insert Book");
                Console.WriteLine("2.Show Book");
                Console.WriteLine("3.Search Book");
                Console.WriteLine("4.Update Book");
                Console.WriteLine("5.Delete Book");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        b.InsertBook();
                        break;
                    case 2:
                        b.ShowBook();
                        break;
                    case 3:
                        b.SearchBook();
                        break;
                    case 4:
                        b.UpdateBook();
                        break;
                    case 5:
                        b.DeleteBook();
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}
