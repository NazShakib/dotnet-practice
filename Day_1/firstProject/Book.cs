using System;

namespace ClassPractice
{

    public class Book{

        public string bookName;
        public int bookQuantity;

        public void bookInfo() {
            Console.WriteLine("Book Name is {0} and Quantity is {1}", bookName, bookQuantity);
        }

        public static Book Parse(string name, int quantity) {

            var book = new Book();
            book.bookName = name;
            book.bookQuantity = quantity;
        }

    }

}
