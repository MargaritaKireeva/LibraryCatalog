using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace pract24_7_graph_interface
{
    public class LibraryFund
    {

        string fundName;//имя фонда
        List<Element> books;//список книг
        public abstract class Element
        {
            public string name;
            public string author;

        }

        public class Periodical : Element
        {
            public Periodical(string name)//периодика (у журналов нет автора)
            {
                this.author = null;
                this.name = name;
            }

        }

        public class Book : Periodical
        {

            public Book(string author, string name) : base(name)//обычная книга
            {
                this.author = author;
            }


        }
       /* public struct Book
        {
            public string author;//автор
            public string name;//название книги

            public Book(string author, string name)//обычная книга
            {
                this.author = author;
                this.name = name;
            }
            public Book(string name)//периодика (у журналов нет автора)
            {
                this.author = null;
                this.name = name;
            }
        }*/
        public LibraryFund(string fundName)
        {
            this.fundName = fundName;
            books = new List<Element>();
        }

        public void AddBook(string author, string name)
        {
            Element book = new Book(author, name);
            if (!books.Contains(book))
                books.Add(book);
        }
        public void AddBook(string name)
        {
            Element book = new Periodical(name);
            if (!books.Contains(book))
                books.Add(book);
        }
        public void DeleteBook(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].name == name)
                {
                    books.Remove(books[i]);
                    break;
                }
            }
        }
        public void Show(string out_)
        {
            using (StreamWriter fileOut = new StreamWriter(out_, true))
            {
                fileOut.WriteLine("Фонд {0}:", fundName);
                foreach (Element book in books)
                {
                    if (book.author == null || book.author == "")
                        fileOut.WriteLine("* {0}", book.name);
                    else fileOut.WriteLine("{0} {1}", book.author, book.name);
                }
            }
        }
        public SortedList<int, string> Show()
        {
            SortedList<int, string> booksList = new SortedList<int, string>();
            int i = 0;
            string bookStr;
                foreach (Element book in books)
                {
                bookStr = book.author + ' ' + book.name;
                booksList.Add(i, bookStr);
                i++;
                }
            return booksList;
        }
        public SortedList<int, string> FindAllBooksByAuthor(string author)
        {
            List<Element> booksByAuthor = new List<Element>();
            foreach (Element book in books)
            {
                if (book.author == author)
                {
                    booksByAuthor.Add(book);
                }
            }
            SortedList<int, string> booksList = new SortedList<int, string>();
            int i = 0;
            string bookStr;
            foreach (Element book in booksByAuthor)
            {
                bookStr = book.author + ' ' + book.name;
                booksList.Add(i, bookStr);
                i++;
            }
            return booksList;
        }
    }
}
