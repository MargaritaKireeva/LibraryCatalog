using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract24_7_graph_interface
{
    public static class CurrentLibraryCatalog
    {
        public static LibraryCatalog libraryCatalog = new LibraryCatalog();
        
    }
    static class Program
    {
       

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (StreamReader fileIn = new StreamReader("input.txt"))
            {
                char[] a = { ' ', '\n', '\t', '\r' };
                string[] input = fileIn.ReadToEnd().Split(a, StringSplitOptions.RemoveEmptyEntries);//читаем файл до конца и записываем все в массив строк
                string concat;//для соединения названия книги
                string fund = input[1];//для соединения названия фонда
                for (int i = 0; i < input.Length;)
                {
                    if (input[i] == "Фонд")//если встретиось слово Фонд, то следующий элемент в массиве точно будет его названием или частью 
                    {
                        i++;
                        fund = input[i]; //объединяем название
                        i++;
                        if (!fund.Contains(':')) //если название не содержит двоеточие, то есть ещё слова в названии
                        {
                            while (!input[i].Contains(':'))//ищем их
                            {
                                fund += ' ';
                                fund += input[i];
                                i++;
                            }
                            fund += ' ';
                            fund += input[i];
                            i++;
                            fund = fund.Remove(fund.Length - 1);//удаляем двоеточие
                        }
                        else fund = fund.Remove(fund.Length - 1);
                        CurrentLibraryCatalog.libraryCatalog.AddFund(fund);

                    }
                    else if (input[i].Contains('\"'))//также объединяем названия книг(если встретили слово с кавычкой, то это начало названия книги
                    {
                        int k = 0; //кол-во прошедших слов
                        concat = input[i]; //объединяем название
                        i++;
                        k++;
                        if (concat.IndexOf('\"') == concat.LastIndexOf('\"'))//если первое вхождение кавычки совпадает с последним
                                                                             //т.е. кавычка одна в этом элементе массиве, значит название состоит из некольких слов
                        {
                            while (!input[i].Contains('\"'))//добавляем их
                            {
                                concat += ' ';
                                concat += input[i];
                                i++;
                                k++;
                            }
                            concat += ' ';
                            concat += input[i];
                            i++;
                            k++;
                        }
                        if (input[i - k - 1] != "*")//если автор = *, то автора нет
                            CurrentLibraryCatalog.libraryCatalog.AddBookInFund(input[i - k - 1], concat, fund);//с автором
                        else CurrentLibraryCatalog.libraryCatalog.AddBookInFund(concat, fund);//добавляем без автора
                    }
                    else i++;

                }

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
