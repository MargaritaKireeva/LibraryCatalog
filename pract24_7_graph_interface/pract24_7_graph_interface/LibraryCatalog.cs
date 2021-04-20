using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace pract24_7_graph_interface
{
    public class LibraryCatalog
    {
        public Hashtable funds;
        public LibraryCatalog()
        {
            funds = new Hashtable();
        }
        public void AddFund(string fundName)
        {
            if (!funds.ContainsKey(fundName))
            {
                LibraryFund fund = new LibraryFund(fundName);
                funds.Add(fundName, fund);
            }

        }
        public void DeleteFund(string fundName)//удаление фонда по его имени
        {
            funds.Remove(fundName);
        }
        public void AddBookInFund(string author, string name, string fundName)//добавить книгу в фонд
        {
            ((LibraryFund)funds[fundName]).AddBook(author, name);

        }
        public void AddBookInFund(string name, string fundName)//добавить книгу в фонд
        {
            ((LibraryFund)funds[fundName]).AddBook(name);

        }
        public void DeleteBookInFund(string name, string fundName)//удалить книгу из фонда
        {
            ((LibraryFund)funds[fundName]).DeleteBook(name);

        }
        public void ShowFund(string fundName)
        {
            File.WriteAllText("ContentOfFund.txt", string.Empty);
            LibraryFund fund = (LibraryFund)funds[fundName];
            fund.Show("ContentOfFund.txt");
        }

        public void ShowCatalog()//просматривать содержимое всего каталога
        {
            File.WriteAllText("input.txt", string.Empty);
            ICollection fundNames = funds.Keys;
            foreach (string fundName in fundNames)
            {
                ((LibraryFund)funds[fundName]).Show("input.txt");
            }

        }
        public List<string> ShowFundNames()
        {
            ICollection fundNames = funds.Keys;
            List<string> fundNamesList = new List<string>();
            foreach (string fundName in fundNames)
            {
                fundNamesList.Add(fundName);
            }
            return fundNamesList;
        }
        public SortedList<int,string> ShowBook(string fundName)
        {
            SortedList<int,string> bookList = ((LibraryFund)funds[fundName]).Show();
            return bookList;
        }
        public SortedList<int, string> FindAllBooksByAuthorInFund(string author, string fundName)
        {
            //File.WriteAllText("FoundBooks.txt", string.Empty);
            return ((LibraryFund)funds[fundName]).FindAllBooksByAuthor(author);
        }

        public SortedList<int, string> FindAllBooksByAuthorInCatalog(string author)
        {
           // File.WriteAllText("FoundBooks.txt", string.Empty);
            ICollection fundNames = funds.Keys;
            SortedList<int, string> booksList = new SortedList<int, string>();
            foreach (string fundName in fundNames)
            {
                ((LibraryFund)funds[fundName]).FindAllBooksByAuthor(author);
            }
            return booksList;
        }
    }

}
