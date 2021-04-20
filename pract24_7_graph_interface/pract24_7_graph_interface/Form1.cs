using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.cyberforum.ru/windows-forms/thread110436.html
namespace pract24_7_graph_interface
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ShowFundNames();
        }

        public void ShowFundNames()
        {
            listBoxFunds.Items.Clear();
            listBoxFunds.Items.Add("Всё содержимое каталога");
            List<string> fundNamesList = CurrentLibraryCatalog.libraryCatalog.ShowFundNames();
            foreach (string fundName in fundNamesList)
            {
                listBoxFunds.Items.Add(fundName);
            }
        }
        public void ShowBook(string fundName)
        {
            
            SortedList<int, string> bookList = CurrentLibraryCatalog.libraryCatalog.ShowBook(fundName);
            ICollection booksNumbers = (ICollection)bookList.Keys;
            foreach (int number in booksNumbers)
            {
                listBoxBooks.Items.Add(bookList[number]);
            }
        }
        public void ShowAllBook()
        {
            List<string> fundNamesList = CurrentLibraryCatalog.libraryCatalog.ShowFundNames();
            foreach (string fundName in fundNamesList)
            {
                ShowBook(fundName);
            }

        }
        public void FindAllBooksByAuthorInFund(string author, string fundName)
        {
            SortedList<int, string> bookList = CurrentLibraryCatalog.libraryCatalog.FindAllBooksByAuthorInFund(textBoxFind.Text, fundName);
            ICollection booksNumbers = (ICollection)bookList.Keys;
            foreach (int number in booksNumbers)
            {
                listBoxBooks.Items.Add(bookList[number]);
            }

        }
        private void AddFund_Click(object sender, EventArgs e)
        {
            Form ifrm = new AddFundForm();
            ifrm.ShowDialog();
            ShowFundNames();
        }

        private void DeleteFund_Click(object sender, EventArgs e)
        {
            CurrentLibraryCatalog.libraryCatalog.DeleteFund(listBoxFunds.SelectedItem.ToString());
            ShowFundNames();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            if (listBoxFunds.SelectedItem.ToString() == "Всё содержимое каталога")
            {
                Form frm = new AddBookInCatalogForm();
                frm.ShowDialog();
                listBoxBooks.Items.Clear();
                ShowAllBook();
            }
            else
            {
                Form ifrm = new AddBookForm(listBoxFunds.SelectedItem.ToString());
                ifrm.ShowDialog();
                listBoxBooks.Items.Clear();
                ShowBook(listBoxFunds.SelectedItem.ToString());
            }
        }

        private void listBoxFunds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFunds.SelectedItem.ToString() == "Всё содержимое каталога")
            {
                listBoxBooks.Items.Clear();
                ShowAllBook();
            }
            else
            {
                listBoxBooks.Items.Clear();
                ShowBook(listBoxFunds.SelectedItem.ToString());
            }
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            char[] a = { ' ', '\n', '\t', '\r' };
            string[] str = listBoxBooks.SelectedItem.ToString().Split(a);
            string name = null;
            for (int i = 0; i < str.Length;)
            {
                if (str[i].Contains('\"'))//объединяем названия книг(если встретили слово с кавычкой, то это начало названия книги
                {
                    name = str[i]; //объединяем название
                    i++;
                    if (name.IndexOf('\"') == name.LastIndexOf('\"'))//если первое вхождение кавычки совпадает с последним
                                                                     //т.е. кавычка одна в этом элементе массиве, значит название состоит из некольких слов
                    {
                        while (!str[i].Contains('\"'))//добавляем их
                        {
                            name += ' ';
                            name += str[i];
                            i++;
                        }
                        name += ' ';
                        name += str[i];
                        i++;
                    }

                }
                else i++;              
            }
            if (listBoxFunds.SelectedItem.ToString() == "Всё содержимое каталога")
            {
                Form frm = new DeleteBookInCatalog();
                frm.ShowDialog();
            }
            else
            {
                CurrentLibraryCatalog.libraryCatalog.DeleteBookInFund(name, listBoxFunds.SelectedItem.ToString());
                listBoxBooks.Items.Clear();
                ShowBook(listBoxFunds.SelectedItem.ToString());
            }
            
        }

        private void Find_Click(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
            if (radioButtonAllBook.Checked)
            {
                listBoxFunds.SetSelected(0, true);
                listBoxBooks.Items.Clear();
                List<string> fundNamesList = CurrentLibraryCatalog.libraryCatalog.ShowFundNames();
                foreach (string fundName in fundNamesList)
                {
                    FindAllBooksByAuthorInFund(textBoxFind.Text, fundName);
                }
            }
            else if (radioButtonFund.Checked)
            {
                FindAllBooksByAuthorInFund(textBoxFind.Text, listBoxFunds.SelectedItem.ToString());
            }    
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            CurrentLibraryCatalog.libraryCatalog.ShowCatalog();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            String drawString = "Фонды";
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 60.0F;
            float y = 10.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawString = "Содержимое фонда/каталога";
            x = 220.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = new SaveBeforeClosing();
            frm.ShowDialog();
        }
    }
}

