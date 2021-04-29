using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Interface
{
    public interface BL_Element_Interface
    {
        void AddBookInFund(Element element);
        void DeleteBookInFund(Element element, string FundName);
        IEnumerable<Element> GetAllBooks();
        IEnumerable<Element> GetAllBooksInFund(string FundName);
        IEnumerable<Element> GetAllBooksByAuthor(string author);
        IEnumerable<Element> GetAllBooksByAuthorInFund(string author, string fundName);
    }
}
