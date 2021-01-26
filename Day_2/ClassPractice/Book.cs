using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Book
    {
        private string name;
        private int id;

        public Book() : this("None",0)
        {

        }
        public Book(string name, int id){
            this.name=name;
            this.id = id;
        }

        ~Book(){
            Console.WriteLine("Destructor was called"); 
        }

        public void printDetails(){
            Console.WriteLine("Book name is {0} and ID is {1}",this.name,this.id);
        }

       

    }
}
