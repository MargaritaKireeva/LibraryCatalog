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
    public partial class AddFundForm : Form
    {
        public AddFundForm()
        {
            InitializeComponent();
        }
       
        private void Add_Click(object sender, EventArgs e)
        {
            if (richTextBoxAdd.Text != "")
            CurrentLibraryCatalog.libraryCatalog.AddFund(richTextBoxAdd.Text);
            Close();
        }

        private void AddFundForm_Paint(object sender, PaintEventArgs e)
        {
            String drawString = "Название фонда";
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 110.0F;
            float y = 60.0F;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y);
        }
    }
}
