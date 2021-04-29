using BL_Interface;
using DAO;
using DAO_Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Element : BL_Element_Interface
    {
        private IElement_DAO_Interface _elementDAO = new Element_DAO();
        public BL_Element()
        {
            this._elementDAO = new Element_DAO();
        }
        public void AddBookInFund(Element element)
        {
            _elementDAO.AddBookInFund(element);
        }
        public void DeleteBookInFund(Element element, string FundName)
        {
            _elementDAO.DeleteBookInFund(element, FundName);
        }
        public IEnumerable<Element> GetAllBooks()
        {
            return _elementDAO.GetAllBooks();
        }
        public IEnumerable<Element> GetAllBooksInFund(string FundName)
        {
            return _elementDAO.GetAllBooksInFund(FundName);
        }
        public IEnumerable<Element> GetAllBooksByAuthor(string author)
        {
            return _elementDAO.GetAllBooksByAuthor(author);
        }
        public IEnumerable<Element> GetAllBooksByAuthorInFund(string author, string fundName)
        {
            return _elementDAO.GetAllBooksByAuthorInFund(author, fundName);
        }
    }
}
