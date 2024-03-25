using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreForms
{
    public partial class AddNewBookSystem : Form
    {
        public AddNewBookSystem()
        {
            InitializeComponent();
        }

        private void exitAddNewBook_Click(object sender, EventArgs e)
        {
            MainMenuForEmployee userProcess = new MainMenuForEmployee();
            userProcess.ShowDialog();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook();   
            var book = new Book();

            string name = txtName.Text;
            book.Name = name;

            string writer = txtWriter.Text;
            book.Writer = writer;

            string publisher = txtPublisher.Text;
            book.Publisher = publisher;

            string pageCount = txtPage.Text;
            book.PageCount = pageCount;

            BookStore.Books.Add(book);
       
        }
    }
}
