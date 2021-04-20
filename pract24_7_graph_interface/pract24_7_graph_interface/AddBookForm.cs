using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract24_7_graph_interface
{
    public partial class AddBookForm : Form
    {
        public AddBookForm(string fundName)
        {
            InitializeComponent();
            this.fundName = fundName;
        }
        string fundName;
        private void Add_Click(object sender, EventArgs e)
        {
           if (richTextBoxAuthor.Text!="" && richTextBoxName.Text != "")
            CurrentLibraryCatalog.libraryCatalog.AddBookInFund(richTextBoxAuthor.Text, '\"'+ richTextBoxName.Text + '\"', fundName);
           else if (richTextBoxName.Text != "")
                CurrentLibraryCatalog.libraryCatalog.AddBookInFund('\"' + richTextBoxName.Text + '\"', fundName);
            Close();
        }

        private void Add_Paint(object sender, PaintEventArgs e)
        {
            String drawString = "Автор";
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 5.0F;
            float y = 10.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawString = "Название";
            y = 20.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
        }

        private void AddBookForm_Paint(object sender, PaintEventArgs e)
        {
            String drawString = "Автор";
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 130.0F;
            float y = 100.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawString = "Название";
            y = 210.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
        }
    }
}
