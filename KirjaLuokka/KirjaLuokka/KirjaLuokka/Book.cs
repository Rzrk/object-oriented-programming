using System;
using System.Collections.Generic;
using System.Text;

namespace KirjaLuokka
{
    class Book
    {
       
        public string Title;
        public string Author;
        public string Id;
        public double Price;

        public Book(string Title, string Author, string Id, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Id = Id;
            this.Price = Price;
        }

        public Book()
        {
        }

        internal string PrintInfo()
        {
            throw new NotImplementedException();
        }

        internal string CompareBook(Book newBook2)
        {
            throw new NotImplementedException();
        }
    }
  
    public string PrintInfo()
    {
        return "Nimi: " + this.Title +
              "\nKirjoittaja: " + this.Author +
              "\nID" + this.Id + "Hinta: " + this.Price;
    }


    public string CompareBook(Book book)
    {
        string text = "";
        if(this.Price > Book.Price)
        {
            text = "";
        }
        else
        {
            text = "";
        }
        return text;

    }
}








