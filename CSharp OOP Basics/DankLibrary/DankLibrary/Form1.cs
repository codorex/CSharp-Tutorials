using DankLibrary.Data.Data;
using DankLibrary.Data.Storage;
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
    public partial class Form1 : Form
    {
        private LibraryStorage _storage;

        public Form1()
        {
            InitializeComponent();

            this._storage = new LibraryStorage();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            AddBookView addBookView = new AddBookView();
            addBookView.ShowDialog();
        }
    }
}
