using DankLibrary.Data.Data;
using DankLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DankLibrary
{
    public partial class AddBookView : Form
    {
        private InMemoryContext _context;
        public AddBookView()
        {
            InitializeComponent();
            _context = InMemoryContext.Instance;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (FormValidator.ValidateTextField(tb_name)  &&
                FormValidator.ValidateNumericField(tb_price) &&
                FormValidator.ValidateNumericField(tb_quantity)
                )
            {
                Book book = new Book()
                {
                    Name = tb_name.Text,
                    Price = Double.Parse(tb_price.Text),
                    Quantity = Int32.Parse(tb_quantity.Text)
                };

                _con
            }
        }
    }
}
