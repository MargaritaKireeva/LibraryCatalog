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
    public partial class DeleteBookInCatalog : Form
    {
        public DeleteBookInCatalog()
        {
            InitializeComponent();
        }

        private void DeleteBookInCatalog_Paint(object sender, PaintEventArgs e)
        {
            String drawString = "Чтобы удалить книгу, нужно выбрать фонд в списке";
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 65.0F;
            float y = 45.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
