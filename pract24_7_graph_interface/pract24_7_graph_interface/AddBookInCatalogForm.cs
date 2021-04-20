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
    public partial class AddBookInCatalogForm : Form
    {
        public AddBookInCatalogForm()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            if (richTextBoxAuthor.Text != "" && richTextBoxName.Text != "")
                CurrentLibraryCatalog.libraryCatalog.AddBookInFund(richTextBoxAuthor.Text, '\"' + richTextBoxName.Text + '\"', richTextBoxFundName.Text);
            else if (richTextBoxName.Text != "")
                CurrentLibraryCatalog.libraryCatalog.AddBookInFund('\"' + richTextBoxName.Text + '\"', richTextBoxFundName.Text);
            Close();
        }

        private void AddBookInCatalogForm_Paint(object sender, PaintEventArgs e)
        {
            String drawString = "Автор";
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 130.0F;
            float y = 45.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawString = "Название";
            y = 150.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawString = "Название фонда";
            y = 280.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
        }
    }
}
